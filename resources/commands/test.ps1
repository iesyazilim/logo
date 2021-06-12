$configuration = $args[0] 
$full = $args[1]

. ".\common.ps1" $configuration $full

foreach ($solutionPath in $solutionPaths) 
{    
    $solutionAbsPath = (Join-Path $rootFolder $solutionPath)
    Write-Host $solutionAbsPath
    Set-Location $solutionAbsPath
    dotnet test --configuration=$configuration --no-restore --no-build --verbosity normal
    if (-Not $?) 
    {
        Write-Host ("Test failed for the solution: " + $solutionPath)
        Set-Location $commandFolder
        exit $LASTEXITCODE
    }
}

Set-Location $commandFolder