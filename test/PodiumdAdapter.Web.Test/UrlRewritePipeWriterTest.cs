﻿using System.IO.Pipelines;
using System.Text;
using PodiumdAdapter.Web.Infrastructure.UrlRewriter;

namespace PodiumdAdapter.Web.Test
{
    public class UrlRewritePipeWriterTest
    {
        [Fact]
        public async Task BasicTest()
        {
            var (read, write) = CreatePipe("with-", "this", "replace-", "me");

            await write("start-replace-me-end");

            var output = await read();
            Assert.Equal("start-with-this-end", output);
        }

        private static (Func<Task<string>> Read, Func<string, Task> Write) CreatePipe(string localRoot, string localPath, string remoteRoot, string remotePath)
        {
            var pipe = new Pipe();
            var reader = pipe.Reader;
            var replacer = new UrlRewriter(localRoot + localPath, remoteRoot + remotePath);
            var writer = new UrlRewritePipeWriter(pipe.Writer, new(localRoot, remoteRoot, [replacer]));
            return (() => ReadToEnd(reader), (s) => WriteToEnd(writer, s));
        }

        private static async Task WriteToEnd(PipeWriter writer, string str)
        {
            await writer.WriteAsync(Encoding.UTF8.GetBytes(str));
            await writer.CompleteAsync();
        }

        private static async Task<string> ReadToEnd(PipeReader reader)
        {
            var stringBuilder = new StringBuilder();
            while (true)
            {
                var pipeReadResult = await reader.ReadAsync();
                var buffer = pipeReadResult.Buffer;

                try
                {
                    //process data in buffer
                    stringBuilder.Append(Encoding.UTF8.GetString(buffer));

                    if (pipeReadResult.IsCompleted)
                    {
                        break;
                    }
                }
                finally
                {
                    reader.AdvanceTo(buffer.Start, buffer.End);
                }
            }

            return stringBuilder.ToString();
        }
    }
}