namespace DvBCrud.Common.Services.Conversion;

/// <inheritdoc cref="IConverterOverride{TDataModel}"/>
public abstract class ConverterOverride<TDataModel> : IConverterOverride<TDataModel>
    where TDataModel : class
{
    public TDataModel ToApiModel(TDataModel dataModel) => dataModel;

    public TDataModel ToDataModel(TDataModel apiModel) => apiModel;
}