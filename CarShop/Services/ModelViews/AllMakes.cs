using CarShop.Models;
using CarShop.Services.Interfaces;
using System.Linq;

namespace CarShop.Services.ModelViews
{
    public class AllMakes : IAllMakes
    {

        IEnumerable<Make> IAllMakes.AllMakesOfCar { get; } = new List<Make>
                {
                    new Make { NameOfMake = "Nissan",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "Leaf"},
                           new ModelOfCar { NameOfModel = "Quashqai"},
                           new ModelOfCar { NameOfModel = "Rock"},
                           new ModelOfCar { NameOfModel = "XTrail"}
                        }
                    },
                    new Make { NameOfMake = "BMW",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "X1"},
                           new ModelOfCar { NameOfModel = "X3"},
                           new ModelOfCar { NameOfModel = "X5"},
                           new ModelOfCar { NameOfModel = "X6"},
                           new ModelOfCar { NameOfModel = "X7"},
                           new ModelOfCar { NameOfModel = "M2"},
                           new ModelOfCar { NameOfModel = "M3"},
                           new ModelOfCar { NameOfModel = "M4"},
                           new ModelOfCar { NameOfModel = "M5"},
                           new ModelOfCar { NameOfModel = "M6"},
                           new ModelOfCar { NameOfModel = "M8"},
                           new ModelOfCar { NameOfModel = "3 series"},
                           new ModelOfCar { NameOfModel = "5 series"},
                           new ModelOfCar { NameOfModel = "7 series"}
                        }
                    },
                    new Make { NameOfMake = "Mercedes",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "A Class"},
                           new ModelOfCar { NameOfModel = "S Class"},
                           new ModelOfCar { NameOfModel = "GLS"},
                           new ModelOfCar { NameOfModel = "E Class"}
                        }
                    },
                    new Make { NameOfMake = "Wolksvagen",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "Golf"},
                           new ModelOfCar { NameOfModel = "Tiguan"},
                           new ModelOfCar { NameOfModel = "Touran"},
                           new ModelOfCar { NameOfModel = "T-Rock"},
                           new ModelOfCar { NameOfModel = "Transporter"},
                           new ModelOfCar { NameOfModel = "Polo"},
                           new ModelOfCar { NameOfModel = "Crafter"}
                        }
                    },
                    new Make { NameOfMake = "Renault",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "Megane"},
                           new ModelOfCar { NameOfModel = "Duster"},
                           new ModelOfCar { NameOfModel = "Kadjar"},
                           new ModelOfCar { NameOfModel = "Logan"}
                        }
                    },
                    new Make { NameOfMake = "Peugeot",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "3008"},
                           new ModelOfCar { NameOfModel = "5008"},
                           new ModelOfCar { NameOfModel = "308"},
                           new ModelOfCar { NameOfModel = "508"}
                        }
                    },
                    new Make { NameOfMake = "Toyota",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "rav4"},
                           new ModelOfCar { NameOfModel = "Camry"},
                           new ModelOfCar { NameOfModel = "Highlander"},
                           new ModelOfCar { NameOfModel = "Land Cruiser"}
                        }
                    },
                    new Make { NameOfMake = "Porsche",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "Cayenne"},
                           new ModelOfCar { NameOfModel = "Macan"},
                           new ModelOfCar { NameOfModel = "Panamera"},
                           new ModelOfCar { NameOfModel = "911"}
                        }
                    },
                    new Make { NameOfMake = "Seat",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "Toledo"}
                        }
                    },
                    new Make { NameOfMake = "Citroen",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "DS-5"},
                           new ModelOfCar { NameOfModel = "DS-4"},
                           new ModelOfCar { NameOfModel = "DS-5"},
                           new ModelOfCar { NameOfModel = "C4"}
                        }
                    },
                    new Make { NameOfMake = "Ford",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "Kuga"},
                           new ModelOfCar { NameOfModel = "Focus"},
                           new ModelOfCar { NameOfModel = "Mustang"},
                           new ModelOfCar { NameOfModel = "Mondeo"},
                           new ModelOfCar { NameOfModel = "F150"}
                        }
                    },
                    new Make { NameOfMake = "Dodge",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "RAM"},
                           new ModelOfCar { NameOfModel = "Challenger"},
                           new ModelOfCar { NameOfModel = "Charger"},
                           new ModelOfCar { NameOfModel = "Dart"}
                        }
                    },
                    new Make { NameOfMake = "Chevrolet",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "Volt"}
                        }
                    },
                    new Make { NameOfMake = "Tesla",
                        Models = new List<ModelOfCar>
                        {
                           new ModelOfCar { NameOfModel = "Model 3"},
                           new ModelOfCar { NameOfModel = "Model s"},
                           new ModelOfCar { NameOfModel = "Model X"},
                           new ModelOfCar { NameOfModel = "Model Y"}
                        }
                    }
        };

        

    }
}
