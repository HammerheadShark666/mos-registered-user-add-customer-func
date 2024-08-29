﻿using Microservice.Customer.Function.Helpers.Exceptions;

namespace Microservice.Customer.Function.Helpers;

public class EnvironmentVariables
{
    public static string AzureServiceBusConnection => GetEnvironmentVariable(Constants.AzureServiceBusConnection);

    public static string GetEnvironmentVariable(string name)
    {
        var variable = Environment.GetEnvironmentVariable(name);

        if (string.IsNullOrEmpty(variable))
            throw new EnvironmentVariableNotFoundException($"Environment Variable Not Found: {name}.");

        return variable;
    }
}