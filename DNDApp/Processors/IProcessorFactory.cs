namespace DNDApp.Processors
{
    public interface IProcessorFactory
    {
        ProcessorBase<TModel> GetProcessor<TModel>(TModel model)
            where TModel : class;
    }
}