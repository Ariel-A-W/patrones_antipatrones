// ********************************************************************
//
// Fecha: 25-05-2024
// 
// Autor: Ariel Alejandro Wagner
// 
// Batería de Pruebas de los Patrones GoF
// ********************************************************************
using GoF.Behavioral.ChainOfResponsability;
using GoF.Behavioral.Command;
using GoF.Behavioral.Interpreter;
using GoF.Behavioral.Iterator;
using GoF.Behavioral.Mediator;
using GoF.Behavioral.Memento;
using GoF.Behavioral.State;
using GoF.Behavioral.Strategy;
using GoF.Behavioral.TemplatedMethod;
using GoF.Behavioral.Visitor;
using GoF.Creational.AbstractFactory;
using GoF.Creational.Builder;
using GoF.Creational.FactoryMethod;
using GoF.Creational.Prototype;
using GoF.Creational.Singleton;
using GoF.Structural.Adapter;
using GoF.Structural.Bridge;
using GoF.Structural.Composite;
using GoF.Structural.Decorator;
using GoF.Structural.Facade;
using GoF.Structural.Proxy;

// *********************************************************************
// CREATIONAL 
// *********************************************************************
Console.WriteLine("Patrones Creational\n");
// Abstract Factory 
Console.WriteLine("Patrón Abstract Factory");
var FactoryMethodTest = new ApplicationFactoryMethod();
FactoryMethodTest.Test();
Console.WriteLine();

// Factory Method
Console.WriteLine("Patrón Factory Method");
var abstractFactoryTest = new ApplicationAbstractFactory();
abstractFactoryTest.Test();
Console.WriteLine();

// Builder 
Console.WriteLine("Patrón Builder");
var builder = new ApplicationBuilder();
builder.Test();
Console.WriteLine();

// Prototype 
Console.WriteLine("Patrón Prototype");
var protoType = new ApplicacionPrototype();
protoType.Test();
Console.WriteLine();

// Singleton 
Console.WriteLine("Patrón Singleton");
var singleton = new ApplicacionSingleton();
singleton.Test();
Console.WriteLine();

// *********************************************************************
// STRUCTURAL  
// *********************************************************************
// Singleton 
Console.WriteLine("Patrón Adapter");
var adapter = new ApplicacionAdapter();
adapter.Test();
Console.WriteLine();

// Bridge 
Console.WriteLine("Patrón Brige");
var bridge = new ApplicacionBridge();
bridge.Test();
Console.WriteLine();

// Composite 
Console.WriteLine("Patrón Composite");
var composite = new ApplicacionComposite();
composite.Test();
Console.WriteLine();

// Decorator 
Console.WriteLine("Patrón Decorator");
var decorator = new ApplicacionDecorator();
decorator.Test();
Console.WriteLine();

// Facade 
Console.WriteLine("Patrón Facade");
var facade = new ApplicacionFacade();
facade.Test();
Console.WriteLine();

// Proxy 
Console.WriteLine("Patrón Proxy");
var proxy = new ApplicacionProxy();
proxy.Test();
Console.WriteLine();

// *********************************************************************
// BEHAVIORAL 
// ********************************************************************* 

// Interpreter 
Console.WriteLine("Patrón Interpreter");
var interpreter = new ApplicacionInterpreter();
interpreter.Test();
Console.WriteLine();

// Templated Method 
Console.WriteLine("Patrón Templated Method");
var templatedMethod = new ApplicacionTemplatedMethod();
templatedMethod.Test();
Console.WriteLine();

// Chain of Responsability
Console.WriteLine("Patrón Chain of Responsability");
var chainOfResponsability = new ApplicacionChainOfResponsability();
chainOfResponsability.Test();
Console.WriteLine();

// Command
Console.WriteLine("Patrón Command");
var command = new ApplicacionCommand();
command.Test();
Console.WriteLine();

// Iterator
Console.WriteLine("Patrón Iterator");
var iterator = new ApplicacionIterator();
iterator.Test();
Console.WriteLine();

// Mediator
Console.WriteLine("Patrón Mediator");
var mediator = new ApplicacionMediator();
mediator.Test();
Console.WriteLine();

// Memento
Console.WriteLine("Patrón Memento");
var memento = new ApplicacionMemento();
memento.Test();
Console.WriteLine();

// State
Console.WriteLine("Patrón State");
var state = new ApplicacionState();
state.Test();
Console.WriteLine();

// Strategy
Console.WriteLine("Patrón Strategy");
var strategy = new ApplicacionStrategy();
strategy.Test();
Console.WriteLine();

// Visitor
Console.WriteLine("Patrón Visitor");
var visitor = new ApplicacionVisitor();
visitor.Test();
Console.WriteLine();