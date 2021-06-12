$configuration = $args[0] 
$assemblyVersion = $args[1]
$packageVersion = $args[2]

. ".\common.ps1" $configuration

if (!$assemblyVersion) 
{ 
   $assemblyVersion = "1.0.0"
   $packageVersion = "1.0.0"
}

foreach ($solutionPath in $solutionPaths) 
{    
    $solutionAbsPath = (Join-Path $rootFolder $solutionPath)
    Write-Host $solutionAbsPath
    Set-Location $solutionAbsPath
    dotnet build --configuration=$configuration /p:AssemblyVersion=$assemblyVersion /p:FileVersion=$assemblyVersion /p:Version=$packageVersion
    if (-Not $?) 
    {
        Write-Host ("Build failed for the solution: " + $solutionPath)
        Set-Location $commandFolder
        exit $LASTEXITCODE
    }
}

Set-Location $commandFolder
