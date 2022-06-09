# .NET Cloud Spanner CMMR Phase 2 example

This version includes support for the Configurable read-only replicas functionality.

## Build and Run

1.  **Follow the set-up instructions in [the documentation](https://cloud.google.com/dotnet/docs/setup).**

2.  Enable APIs for your project.
    [Click here](https://console.cloud.google.com/flows/enableapi?apiid=spanner.googleapis.com&showconfirmation=true)
    to visit Cloud Platform Console and enable the Google Cloud Spanner API.

3.  Install the following nuget package present in the folder "Nuget Packages":
	 Google.Cloud.Spanner.Data

4.  Edit `CmmrPhase2\Program.cs`, and  
	- Replace "projectId" with the id of the source project 
	- Replace "baseInstanceConfig" with the id of the source instance
	- Replace "customInstanceConfig" with the id of the custom source instance

5. Authenticate using : gcloud auth application-default login --no-launch-browser

### Run the Quickstart samples
Run the sample using the following commands.
```
dotnet run create_instance_config
dotnet run update_instance_config
dotnet run delete_instance_config
dotnet run list_instance_config_operations
```