 pipeline {
    //agent { docker { image 'maven:3.8.4-openjdk-11-slim' } }
    agent any
    //agent { dockerfile true }
    environment {
        //workspace = "C:\\Users\\Ar0n\\source\\repos"
        project = "Selenium"
        solutionName = "Selenium"
        testsPath = "Selenium"
    }
    
    stages {
        
        stage ('Clean workspace') {
            steps {
                cleanWs()
            }
        }
                
        stage ('Git Pull Selenium Tests') {
            steps {
                git branch: 'main', url: 'https://github.com/ragavendra/Selenium'
            }
        }
      
        stage('Restore packages') {
            steps {
                bat "dotnet restore ${workspace}\\${solutionName}.sln"
            }
        }
      
        /*
        stage('Clean') {
            steps {
                bat "msbuild.exe ${workspace}\\${solutionName}.sln /nologo /nr:false /p:platform=\"x64\" /p:configuration=\"release\" /t:clean"
            }
        }
        stage('Increase version') {
            steps {
                echo "${env.BUILD_NUMBER}"
                powershell '''
                   $xmlFileName = "<path-to-solution>\\<package-project-name>\\Package.appxmanifest"     
                   [xml]$xmlDoc = Get-Content $xmlFileName
                   $version = $xmlDoc.Package.Identity.Version
                   $trimmedVersion = $version -replace '.[0-9]+$', '.'
                   $xmlDoc.Package.Identity.Version = $trimmedVersion + ${env:BUILD_NUMBER}
                   echo 'New version:' $xmlDoc.Package.Identity.Version
                   $xmlDoc.Save($xmlFileName)
                '''
             }
         }*/

        stage('Running unit tests') {
            steps {
                bat "dotnet add ${workspace}\\${testsPath}\\Selenium.csproj package JUnitTestLogger --version 1.1.0"
                bat "dotnet test ${workspace}\\${testsPath}\\Selenium.csproj --logger \"junit;LogFilePath=\"${WORKSPACE}\"\\TestResults\\1.0.0.\"${env.BUILD_NUMBER}\"\\results.xml\" --configuration release --collect \"Code coverage\""
                powershell '''
                  $destinationFolder = \"$env:WORKSPACE\\TestResults\"
                  if (!(Test-Path -path $destinationFolder)) {New-Item $destinationFolder -Type Directory}
                  $file = Get-ChildItem -Path \"$env:WORKSPACE\\TestResults/*/*.coverage\"
                  $file | Rename-Item -NewName testcoverage.coverage
                  $renamedFile = Get-ChildItem -Path \"$env:WORKSPACE\\TestResults\\*/*.coverage\"
                  echo $renamedFile
                '''            
            }        
        }
        /* cannot continue as $renamedFile is blank
        stage('Convert coverage file to xml coverage file') {
            steps {
                bat "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\microsoft.codecoverage\\16.11.0\\build\\netstandard1.0\\CodeCoverage\\amd64\\CodeCoverage.exe analyze  /output:${workspace}\\TestResults\\xmlresults.coveragexml  ${workspace}\\TestResults\\testcoverage.coverage"
            }
        }
        
        stage('Generate report') {
            steps {
                bat "E:\\Jenkin\\ReportGenerator.exe -reports:${workspace}\\TestResults\\xmlresults.coveragexml -targetdir:${workspace}\\CodeCoverage_${env.BUILD_NUMBER}"
            }
        }
        
        stage('Publish HTML report') {
            steps {
                publishHTML(target: [allowMissing: false, alwaysLinkToLastBuild: false, keepAll: false, reportDir: 'CodeCoverage_${BUILD_NUMBER}', reportFiles: 'index.html', reportName: 'HTML Report', reportTitles: 'Code Coverage Report'])
            }
        }*/
    }
}
