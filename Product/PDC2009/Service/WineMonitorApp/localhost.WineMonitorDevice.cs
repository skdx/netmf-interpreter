﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/WineMonitorDevice/", ConfigurationName="IWineMonitorRequest")]
public interface IWineMonitorRequest
{
    
    // CODEGEN: Parameter 'GetSensorDataResult' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
    [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WineMonitorDevice/IWineMonitorRequest/GetSensorData", ReplyAction="http://localhost/WineMonitorDevice/IWineMonitorRequest/GetSensorDataResponse")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    GetSensorDataResponse GetSensorData(GetSensorDataRequest request);
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/WineMonitorDevice")]
public partial class WineSensorData
{
    
    private double humidityField;
    
    private bool humidityFieldSpecified;
    
    private double temperatureField;
    
    private bool temperatureFieldSpecified;
    
    private System.DateTime timeStampField;
    
    private bool timeStampFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public double Humidity
    {
        get
        {
            return this.humidityField;
        }
        set
        {
            this.humidityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool HumiditySpecified
    {
        get
        {
            return this.humidityFieldSpecified;
        }
        set
        {
            this.humidityFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public double Temperature
    {
        get
        {
            return this.temperatureField;
        }
        set
        {
            this.temperatureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TemperatureSpecified
    {
        get
        {
            return this.temperatureFieldSpecified;
        }
        set
        {
            this.temperatureFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public System.DateTime TimeStamp
    {
        get
        {
            return this.timeStampField;
        }
        set
        {
            this.timeStampField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TimeStampSpecified
    {
        get
        {
            return this.timeStampFieldSpecified;
        }
        set
        {
            this.timeStampFieldSpecified = value;
        }
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetSensorData", WrapperNamespace="http://localhost/WineMonitorDevice/", IsWrapped=true)]
public partial class GetSensorDataRequest
{
    
    public GetSensorDataRequest()
    {
    }
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.MessageContractAttribute(WrapperName="GetSensorDataResponse", WrapperNamespace="http://localhost/WineMonitorDevice/", IsWrapped=true)]
public partial class GetSensorDataResponse
{
    
    [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://localhost/WineMonitorDevice/", Order=0)]
    [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
    public WineSensorData GetSensorDataResult;
    
    public GetSensorDataResponse()
    {
    }
    
    public GetSensorDataResponse(WineSensorData GetSensorDataResult)
    {
        this.GetSensorDataResult = GetSensorDataResult;
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface IWineMonitorRequestChannel : IWineMonitorRequest, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class WineMonitorRequestClient : System.ServiceModel.ClientBase<IWineMonitorRequest>, IWineMonitorRequest
{
    
    public WineMonitorRequestClient()
    {
    }
    
    public WineMonitorRequestClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public WineMonitorRequestClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WineMonitorRequestClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public WineMonitorRequestClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    GetSensorDataResponse IWineMonitorRequest.GetSensorData(GetSensorDataRequest request)
    {
        return base.Channel.GetSensorData(request);
    }
    
    public WineSensorData GetSensorData()
    {
        GetSensorDataRequest inValue = new GetSensorDataRequest();
        GetSensorDataResponse retVal = ((IWineMonitorRequest)(this)).GetSensorData(inValue);
        return retVal.GetSensorDataResult;
    }
}
