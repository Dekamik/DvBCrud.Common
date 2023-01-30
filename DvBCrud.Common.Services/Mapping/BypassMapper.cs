namespace DvBCrud.Common.Services.Mapping;

/// <inheritdoc cref="IBypassMapper{TDataModel}"/>
public abstract class BypassMapper<TDataModel> : IBypassMapper<TDataModel>
    where TDataModel : class
{
    public TDataModel ToModel(TDataModel dataModel) => dataModel;

    public TDataModel ToEntity(TDataModel apiModel) => apiModel;
}