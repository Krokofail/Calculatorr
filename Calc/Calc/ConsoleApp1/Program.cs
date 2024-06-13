using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;


namespace CalculatorCsharp
{

    public class Program
    {
        private readonly IWindsorContainer _container;

        public Program(IWindsorContainer container)
        {
            _container = container;
        }

        public static void Main()
        {
            try
            {
                IWindsorContainer container = new WindsorContainer();
                Program program = new Program(container);
                program.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void Start()
        {
            _container.Kernel.AddFacility<StartableFacility>(f => f.DeferredStart());
            _container.Kernel.Resolver.AddSubResolver(new CollectionResolver(_container.Kernel));
            _container.Install(new LocalInstaller());
        }
    }


    internal class LocalInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IWindsorContainer>().Instance(container),
                Component.For<Application>()
                         .StartUsingMethod("Run"),

                Component.For<IMenuItemSelector<IOperationExecutor<double>>>()
                         .ImplementedBy<OperationMenuItemSelector>()
                         .LifestyleTransient(),
                Component.For<IMenuItemSelectorProvider>()
                         .ImplementedBy<OperationMenuItemSelectorView>()
                         .LifestyleTransient(),
                Component.For<IOperationProvider>()
                         .ImplementedBy<OperationProvider>(),


                Component.For<IMenu<IOperationExecutor<double>>>()
                         .ImplementedBy<OperationMenu>()
                         .LifestyleTransient(),

                Component.For<IOperationArgsProvider<OneStandartArgs>>()
                         .ImplementedBy<OneStandartOperationArgsProvider>(),
                Component.For<IOperationArgsProvider<TwoStandartArgs>>()
                         .ImplementedBy<TwoStandartOperationArgsProvider>(),
                Component.For<IOperationArgsProvider<PowArgs>>()
                         .ImplementedBy<PowOperationArgsProvider>(),
                Component.For<IOperationArgsProvider<LogArgs>>()
                         .ImplementedBy<LogStandartOperationArgsProvider>(),
                Component.For<IOperationArgsProvider<LogicArgs>>()
                         .ImplementedBy<LogicStandartOperationArgsProvider>(),



                Component.For<IAddition>()
                         .ImplementedBy<Addition>(),
                Component.For<ISubstraction>()
                         .ImplementedBy<Substraction>(),
                Component.For<IMultiplication>()
                         .ImplementedBy<Multiplication>(),
                Component.For<IDivision>()
                         .ImplementedBy<Division>(),
                Component.For<ISqrt>()
                         .ImplementedBy<Sqrt>(),
                Component.For<ICos>()
                         .ImplementedBy<Cos>(),
                Component.For<IPow>()
                         .ImplementedBy<Pow>(),
                Component.For<ISin>()
                         .ImplementedBy<Sin>(),
                Component.For<ITg>()
                         .ImplementedBy<Tg>(),
                Component.For<ILog>()
                         .ImplementedBy<Log>(),
                Component.For<ICtg>()
                         .ImplementedBy<Ctg>(),
                Component.For<ILogicAnd>()
                         .ImplementedBy<LogicAnd>(),
                Component.For<ILogicOr>()
                         .ImplementedBy<LogicOr>(),



                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<AdditionOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<SubstractionOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<MultiplicationOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<DivisionOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<SqrtOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<CosOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<PowOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<SinOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<TgOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<LogOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<CtgOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<LogicAndOperation>(),
                Component.For<IOperationExecutor<double>>()
                         .ImplementedBy<LogicOrOperation>()



            );
        }
    }


    public class Application
    {
        public Application(
            IMenu<IOperationExecutor<double>> menu)
        {
            this.menu = menu;
        }

        private IMenu<IOperationExecutor<double>> menu;

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                IOperationExecutor<double> operation = menu.Show().ItemSelector.Select();
                Console.Clear();
                Console.WriteLine($"Результат: {operation.Execute()}");
                Console.WriteLine("Нажмите клавишу 'z' для выхода из калькулятора или любую клавишу для продолжения");
                if (Console.ReadLine().ToLower() == "z") break;
            }
        }
    }

}