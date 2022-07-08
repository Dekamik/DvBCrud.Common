namespace DvBCrud.Common.Services.Conversion;

/// <summary>
/// Base class for implementing conversion logic between <typeparamref name="TDataModel"/> and <typeparamref name="TApiModel"/>.
/// </summary>
/// <typeparam name="TDataModel">Entity/data model type</typeparam>
/// <typeparam name="TApiModel">API model type</typeparam>
public interface IConverter<TDataModel, TApiModel>
{
    TApiModel ToApiModel(TDataModel dataModel);
    TDataModel ToDataModel(TApiModel apiModel);
}