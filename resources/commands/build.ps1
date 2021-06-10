$configuration = $args[0] 

. ".\common.ps1" $configuration


foreach ($solutionPath in $solutionPaths) 
{    
    $solutionAbsPath = (Join-Path $rootFolder $solutionPath)
    Write-Host $solutionAbsPath
    Set-Location $solutionAbsPath
    dotnet build --configuration=$configuration
    if (-Not $?) 
    {
        Write-Host ("Build failed for the solution: " + $solutionPath)
        Set-Location $commandFolder
        exit $LASTEXITCODE
    }
}

Set-Location $commandFolder