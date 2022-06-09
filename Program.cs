/*
 * Copyright (c) 2022 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */

using System;
using System.Threading.Tasks;

namespace CmmrPhase2
{
    public class CmmrPhase2
    {
        private static string _usageString = @"Usage: CmmrPhase2.exe <command>
	Command can be one of: create_instance_config, update_instance_config, delete_instance_config, list_instance_config_operations
Examples:
	CmmrPhase2.exe create_instance_config
	CmmrPhase2.exe update_instance_config
	CmmrPhase2.exe delete_instance_config
	CmmrPhase2.exe list_instance_config_operations";

        public static async Task Main(string[] args)
        {
            string projectId = "source_Project_id";
            // baseConfigName = "nam7" OR baseConfigName = "eur6"
            string baseInstanceConfig = "source_Instance_id";
            // Custom config names must start with the prefix “custom-”.
            string customInstanceConfig = "custom_Instance_config";

            if (args.Length < 1)
            {
                Console.WriteLine(_usageString);
                return;
            }

            var command = args[0];

            switch (command)
            {
                case "create_instance_config":
                    await CreateInstanceConfig(projectId, baseInstanceConfig, customInstanceConfig);
                    break;
                case "update_instance_config":
                    await UpdateInstanceConfig(projectId, customInstanceConfig);
                    break;
                case "delete_instance_config":
                    await DeleteInstanceConfig(projectId, customInstanceConfig);
                    break;
                case "list_instance_config_operations":
                    await ListInstanceConfigOperations(projectId);
                    break;
                default:
                    Console.WriteLine(_usageString);
                    break;
            }
        }

        private static async Task ListInstanceConfigOperations(string projectId)
        {
            var listInstanceConfigOperations = new ListInstanceConfigOperationsAsyncSample();
            await listInstanceConfigOperations.ListInstanceConfigOperationsAsync(projectId);
        }

        private static async Task CreateInstanceConfig(string projectId, string baseInstanceConfig, string customInstanceConfig)
        {
            var createInstanceConfig = new CreateInstanceConfigAsyncSample();
            await createInstanceConfig.CreateInstanceConfigAsync(projectId, baseInstanceConfig, customInstanceConfig);
        }

        private static async Task UpdateInstanceConfig(string projectId, string instanceConfig)
        {
            var updateInstanceConfig = new UpdateInstanceConfigAsyncSample();
            await updateInstanceConfig.UpdateInstanceConfigAsync(projectId, instanceConfig);
        }
        private static async Task DeleteInstanceConfig(string projectId, string instanceConfig)
        {
            var deleteInstanceConfig = new DeleteInstanceConfigAsyncSample();
            await deleteInstanceConfig.DeleteInstanceConfigAsync(projectId, instanceConfig);
        }
    }
}
