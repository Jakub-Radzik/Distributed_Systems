﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICalculator")]
public interface ICalculator
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
    double Add(double n1, double n2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Add", ReplyAction="http://tempuri.org/ICalculator/AddResponse")]
    System.Threading.Tasks.Task<double> AddAsync(double n1, double n2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Sub", ReplyAction="http://tempuri.org/ICalculator/SubResponse")]
    double Sub(double n1, double n2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Sub", ReplyAction="http://tempuri.org/ICalculator/SubResponse")]
    System.Threading.Tasks.Task<double> SubAsync(double n1, double n2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
    double Multiply(double n1, double n2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculator/Multiply", ReplyAction="http://tempuri.org/ICalculator/MultiplyResponse")]
    System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICalculatorChannel : ICalculator, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CalculatorClient : System.ServiceModel.ClientBase<ICalculator>, ICalculator
{
    
    public CalculatorClient()
    {
    }
    
    public CalculatorClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double Add(double n1, double n2)
    {
        return base.Channel.Add(n1, n2);
    }
    
    public System.Threading.Tasks.Task<double> AddAsync(double n1, double n2)
    {
        return base.Channel.AddAsync(n1, n2);
    }
    
    public double Sub(double n1, double n2)
    {
        return base.Channel.Sub(n1, n2);
    }
    
    public System.Threading.Tasks.Task<double> SubAsync(double n1, double n2)
    {
        return base.Channel.SubAsync(n1, n2);
    }
    
    public double Multiply(double n1, double n2)
    {
        return base.Channel.Multiply(n1, n2);
    }
    
    public System.Threading.Tasks.Task<double> MultiplyAsync(double n1, double n2)
    {
        return base.Channel.MultiplyAsync(n1, n2);
    }
}
