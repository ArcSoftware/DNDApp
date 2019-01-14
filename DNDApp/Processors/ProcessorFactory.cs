using System;
using System.Collections.Generic;
using DNDApp.Common.Interfaces;
using DNDApp.Common.Validation;

namespace DNDApp.Processors
{
    public class ProcessorFactory : IProcessorFactory
    {
        private readonly IRepository _repo;

        //Dictionary to lookup a ProcessorBase type the model
        private readonly Dictionary<Type, Type> _processorDictionary;

        //Dictionary to lookup Validator type from ProcessorBase type
        private readonly Dictionary<Type, Type> _processorValidatorDictionary;

        public ProcessorFactory(
            IRepository repo, 
            Dictionary<Type, Type> processorDictionary, 
            Dictionary<Type, Type> processorValidatorDictionary)
        {
            _repo = repo;
            _processorDictionary = processorDictionary;
            _processorValidatorDictionary = processorValidatorDictionary;
        }

        public ProcessorBase<TModel> GetProcessor<TModel>(TModel model) where TModel : class
        {
            var processorType = _processorDictionary[typeof(TModel)];
            var validatorType = _processorValidatorDictionary[processorType];
            var validator = Activator.CreateInstance(validatorType, _repo);
            return Activator.CreateInstance(processorType, (IValidator<TModel>) validator, _repo) as
                ProcessorBase<TModel>;
        }
    }
}