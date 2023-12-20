// See https://aka.ms/new-console-template for more information




using Autofac;
using Autofac.Extras.DynamicProxy;
using Interceptor;



var builder = new ContainerBuilder();

// Servis sınıfını register etme ve interceptor'ı ekleyerek configure etme

builder.RegisterType<Product>()
    .As<IProduct>()
    .SingleInstance()
    .EnableInterfaceInterceptors()
    .InterceptedBy(typeof(MyInterceptor));



// Interceptor'ı register etme
builder.Register(c => new MyInterceptor());

var container = builder.Build();

// Autofac'tan servis örneği alma
var service = container.Resolve<IProduct>();

// Metodu çağırma
var result = service.Sum(10, 20);


string deger = service.GetName();
Console.WriteLine(result);