namespace DNDApp.Processors
{
    public interface IProcessorFactory
    {
        ProcessorBase<TModel> GetProcessor<TModel>()
            where TModel : class;
    }
}