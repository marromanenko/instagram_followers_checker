string methodName = context.InputParameters["MethodName"].ToString();
            var entityMetadata = new  MetadataService(service).GetEntityMetadataForCalculation();

            switch (methodName)
            {
                case "ActiveUsers":
                    {
                        CalculationMetadata response = new CalculationMetadata()
                        {
                            ActiveUsers = new MetadataService(service).GetActiveUsersCount()
                        };
                        context.OutputParameters["CalculationMetadata"] = JsonSerializer.Serialize<CalculationMetadata>(response);
                        return;
                    }
                case "CustomPluginAssemblies":
                    {
                        CalculationMetadata response = new CalculationMetadata()
                        {
                            CustomPluginAssemblies = new MetadataService(service).GetCustomPluginAssembliesCount()
                        };
                        context.OutputParameters["CalculationMetadata"] = JsonSerializer.Serialize<CalculationMetadata>(response);
                        return;
                    }
                case "CustomPlugins":
                    {
                        CalculationMetadata response = new CalculationMetadata()
                        {
                            CustomPlugins = new MetadataService(service).GetCustomPluginsCount()
                        };
                        context.OutputParameters["CalculationMetadata"] = JsonSerializer.Serialize<CalculationMetadata>(response);
                        return;
                    }
                case "CustomPluginSteps":
                    {
                        CalculationMetadata response = new CalculationMetadata()
                        {
                            CustomPluginSteps = new MetadataService(service).GetCustomPluginStepsCount()
                        };
                        context.OutputParameters["CalculationMetadata"] = JsonSerializer.Serialize<CalculationMetadata>(response);
                        return;
                    }
                case "CustomWebResources":
                    {
                        CalculationMetadata response = new CalculationMetadata()
                        {
                            CustomWebResources = new MetadataService(service).GetCustomWebResourcesCount()
                        };
                        context.OutputParameters["CalculationMetadata"] = JsonSerializer.Serialize<CalculationMetadata>(response);
                        return;
                    }
                case "CustomWorkflows":
                    {
                        CalculationMetadata response = new CalculationMetadata()
                        {
                            CustomWorkflows = new MetadataService(service).GetCustomWorkflowsCount()
                        };
                        context.OutputParameters["CalculationMetadata"] = JsonSerializer.Serialize<CalculationMetadata>(response);
                        return;
                    }
                case "Reports":
                    {
                        CalculationMetadata response = new CalculationMetadata()
                        {
                            Reports = new MetadataService(service).GetReportsCount()
                        };
                        context.OutputParameters["CalculationMetadata"] = JsonSerializer.Serialize<CalculationMetadata>(response);
                        return;
                    }
                case "CrmVersion":
                    {
                        CalculationMetadata response = new CalculationMetadata()
                        {
                            CrmVersion = new MetadataService(service).GetCrmVersion()
                        };
                        context.OutputParameters["CalculationMetadata"] = JsonSerializer.Serialize<CalculationMetadata>(response);
                        return;
                    }
                case "CustomEntities":
                    {
                        CalculationMetadata response = new CalculationMetadata()
                        {
                            CustomEntities = entityMetadata.CustomEntitiesCount
                        };
                        context.OutputParameters["CalculationMetadata"] = JsonSerializer.Serialize<CalculationMetadata>(response);
                        return;
                    }
                case "CustomEntitiesFields":
                    {
                        CalculationMetadata response = new CalculationMetadata()
                        {
                            CustomEntitiesFields = entityMetadata.CustomEntitiesFieldsCount
                        };
                        context.OutputParameters["CalculationMetadata"] = JsonSerializer.Serialize<CalculationMetadata>(response);
                        return;
                    }
                case "StandardEntitiesCustomFields":
                    {
                        CalculationMetadata response = new CalculationMetadata()
                        {
                            StandardEntitiesCustomFields = entityMetadata.StandardEntitiesCustomFieldsCount
                        };
                        context.OutputParameters["CalculationMetadata"] = JsonSerializer.Serialize<CalculationMetadata>(response);

                        return;
                    }
                default:
                    {
                        return;
                    }
            }
            
            
            
            
            
            
            
            
            
