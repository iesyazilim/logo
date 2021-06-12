$configuration = $args[0]
$full = $args[1]

$rootFolder = (Get-Item -Path "../../" -Verbose).FullName
$commandFolder = (Get-Item -Path "./" -Verbose).FullName

$solutionPaths = 
@(
    "framework",
    "modules/logo-app"
)

if ($full -eq "-f")
{
	$solutionPaths += 
    (
		"samples/Ies.SampleApp",
		"samples/Ies.MultiFirm"
	) 
}

if (!$configuration) 
{ 
   $configuration="Debug"
}
elseif(!($configuration -eq "Release"))
{
    Write-Host ("Configuration must be Debug or Release current configuration: " + $configuration)
    exit
}

Write-Host $solutionPaths
