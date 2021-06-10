$configuration = $args[0] 
$packageVersion = $args[1]
$packagePath = $args[2]

. ".\common.ps1" $configuration

foreach ($solutionPath in $solutionPaths) 
{    
    $solutionAbsPath = (Join-Path $rootFolder $solutionPath)
    Write-Host $solutionAbsPath
    Set-Location $solutionAbsPath
    dotnet pack --no-restore --no-build --configuration=$configuration -p:PackageVersion=$packageVersion --output=$packagePath
    if (-Not $?) 
    {
        Write-Host ("Test failed for the solution: " + $solutionPath)
        Set-Location $commandFolder
        exit $LASTEXITCODE
    }
}
Set-Location $commandFolder
