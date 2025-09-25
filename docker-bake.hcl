target "test" {
  dockerfile = "src/PodiumdAdapter.Web/Dockerfile"
  tags       = ["test"]
  cache-from = ["type=gha,scope=cache"]
  cache-to   = ["type=gha,mode=max,scope=cache"]
  output     = ["testresults"]
}