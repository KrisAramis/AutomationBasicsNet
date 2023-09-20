using Decorator;

static void Main(string[] args)
{
    
IGigantosaurus gosha = new Gigantosaurus();
IGigantosaurus loudDecorator = new LoudGigantosarusDecorator(gosha);
loudDecorator.Roar();
IGigantosaurus extraLoudDecorator = new ExtraLoudGigantosaurusDecorator(gosha);
extraLoudDecorator.Roar();

}