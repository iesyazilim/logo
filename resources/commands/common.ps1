$configuration = $args[0]
$full = $args[1]

$rootFolder = (Get-Item -Path "../../" -Verbose).FullName
$commandFolder = (Get-Item -Path "./" -Verbose).FullName
$solutionPaths = @("framework")

function AddSolutions([string] $subFolder)
{
    Set-Location (Join-Path $rootFolder $subFolder)
    $paths = @()
    foreach ($csproj in $(Get-ChildItem -Recurse . -Filter *.sln) )
    { 
        $paths += (( $csproj.Directory -split '\\' | select -last 2 ) -join '/')
    }
    return $paths
}

$solutionPaths+=AddSolutions('modules')

if ($full -eq "-f")
{
	$solutionPaths+=AddSolutions('samples')
}

if (!$configuration) 
{ 
   $configuration="Debug"
}
elseif(!($configuration -eq "Release"))
{
    Write-Host ("Configuration must be Debug or Release current configuration: " + $configuration)
    Set-Location $commandFolder
    exit
}

Set-Location $commandFolder
