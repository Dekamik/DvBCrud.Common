namespace DvBCrud.Common.Services.Conversion;

/// <summary>
/// Simple implementation to override the conversion logic of <typeparamref name="TDataModel"/>.
/// Use this if you intend to expose your data model directly.
///
/// When you decide to implement your own converter, inherit from <see cref="IConverter{TDataModel,TApiModel}"/> instead.
/// </summary>
/// <typeparam name="TDataModel">Entity/data model type</typeparam>
public interface IConverterOverride<TDataModel> : IConverter<TDataModel, TDataModel>
    where TDataModel : class
{
}