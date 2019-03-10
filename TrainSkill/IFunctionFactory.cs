using TrainSkill.Functions;

namespace TrainSkill
{
    public interface IFunctionFactory
    {
        TFunction Create<TFunction>(string name = null) where TFunction : IFunction;
    }
}
