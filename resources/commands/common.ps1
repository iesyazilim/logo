$configuration = $args[0]
$rootFolder = (Get-Item -Path "../../" -Verbose).FullName
$commandFolder = (Get-Item -Path "./" -Verbose).FullName

$solutionPaths = 
@(
    "framework",
    "modules/logo-app"
)

if (!$configuration) 
{ 
   $configuration="Debug"
}
elseif(!($configuration -eq "Release"))
{
    Write-Host ("Configuration must be Debug or Release current configuration: " + $configuration)
    exit
}
