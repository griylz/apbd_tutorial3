using ConsoleApp1.Containers;
using ConsoleApp1.Ship;


Dictionary<string, ContainerShip> ships = new Dictionary<string, ContainerShip>();
Dictionary<string, Container> containers = new Dictionary<string, Container>();

var liquidContainer = new LiquidContainer(250, 5000, 200, 10000, true);
containers.Add(liquidContainer.SerialNumber, liquidContainer);
var shipA = new ContainerShip(30, 10, 200000);
ships.Add("ShipA", shipA);
//Exception example
// containers["KON-L-1"].Load(8000);
shipA.LoadContainer(containers["KON-L-1"]);
shipA.UnloadContainer("KON-L-1");
containers["KON-L-1"].Unload();
var replacementContainer = new LiquidContainer(250, 5000, 200, 10000, false);
containers.Add(replacementContainer.SerialNumber, replacementContainer);
shipA.LoadContainer(replacementContainer); 
var shipB = new ContainerShip(25, 20, 300000);
ships.Add("ShipB", shipB);
shipA.UnloadContainer(replacementContainer.SerialNumber);
shipB.LoadContainer(replacementContainer);
shipA.PrintShipInfo();
shipB.PrintShipInfo();
