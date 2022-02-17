using InterfacesExercises;
using InterfacesExercises.Activities;

var cookPizza = new CookPizza();
var buyBusTicket = new BuyBusTicket();

var workflowEngine = new WorkflowEngine(cookPizza);
//var workflowEngine = new WorkflowEngine(buyBusTicket);

workflowEngine.Run();
