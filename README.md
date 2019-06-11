# Arbol-Binario
Crear un árbol binario y obtener el antecesor común entre 2 nodos dados.

Solucion creada en Visual Studio 2013.

Contiene 1 solucion con 3 proyectos. 1 API y 2 librerias de clases para entidades y rule.

Para ponerla en funcionameinto basta con descargarla, compilarlar y ejecutar. se puede publicar en un IIS fw4 de ser necesario para ser consumida.

Al ejecutar el api muestra 1 ventana con la documentacion de los metodos y los parametros para los tipo POST.
Aca agrego los ejemplos de como consumirla.


----------------------------------------------------------------------------------------------------------
1. URL: POST  localhost:10629/api/Arbol/CreateTree

Crea el arbol con los valores qeu se solicite. Tanto el numero de niveles como los valores de los nodos se generan aleatoreamente.

    Json Request body:
{
  "MaximoNiveles": 6,
  "ValorMaximo": 100,
  "ValorMinimo": 0
}

    Json Respuesta:

{
  "Arbol": {
    "Valor": 3,
    "Izquierdo": {
      "Valor": 90,
      "Izquierdo": {
        "Valor": 42,
        "Izquierdo": null,
        "Derecho": null
      },
      "Derecho": {
        "Valor": 30,
        "Izquierdo": null,
        "Derecho": null
      }
    },
    "Derecho": {
      "Valor": 48,
      "Izquierdo": {
        "Valor": 80,
        "Izquierdo": null,
        "Derecho": null
      },
      "Derecho": {
        "Valor": 82,
        "Izquierdo": null,
        "Derecho": null
      }
    }
  },
  "NumeroNiveles": 3
}

----------------------------------------------------------------------------------------------------------------

2) URL: POST localhost:10629/api/Arbol/LowestCommonAncestor

    Json request:
{
  "Arbol": {
    "Valor": 54,
    "Izquierdo": {
      "Valor": 10,
      "Izquierdo": {
        "Valor": 50,
        "Izquierdo": {
          "Valor": 35,
          "Izquierdo": {
            "Valor": 4,
            "Izquierdo": null,
            "Derecho": null
          },
          "Derecho": {
            "Valor": 75,
            "Izquierdo": null,
            "Derecho": null
          }
        },
        "Derecho": {
          "Valor": 87,
          "Izquierdo": {
            "Valor": 84,
            "Izquierdo": null,
            "Derecho": null
          },
          "Derecho": {
            "Valor": 94,
            "Izquierdo": null,
            "Derecho": null
          }
        }
      },
      "Derecho": {
        "Valor": 17,
        "Izquierdo": {
          "Valor": 62,
          "Izquierdo": {
            "Valor": 64,
            "Izquierdo": null,
            "Derecho": null
          },
          "Derecho": {
            "Valor": 59,
            "Izquierdo": null,
            "Derecho": null
          }
        },
        "Derecho": {
          "Valor": 44,
          "Izquierdo": {
            "Valor": 65,
            "Izquierdo": null,
            "Derecho": null
          },
          "Derecho": {
            "Valor": 25,
            "Izquierdo": null,
            "Derecho": null
          }
        }
      }
    },
    "Derecho": {
      "Valor": 96,
      "Izquierdo": {
        "Valor": 52,
        "Izquierdo": {
          "Valor": 22,
          "Izquierdo": {
            "Valor": 43,
            "Izquierdo": null,
            "Derecho": null
          },
          "Derecho": {
            "Valor": 0,
            "Izquierdo": null,
            "Derecho": null
          }
        },
        "Derecho": {
          "Valor": 85,
          "Izquierdo": {
            "Valor": 3,
            "Izquierdo": null,
            "Derecho": null
          },
          "Derecho": {
            "Valor": 38,
            "Izquierdo": null,
            "Derecho": null
          }
        }
      },
      "Derecho": {
        "Valor": 26,
        "Izquierdo": {
          "Valor": 20,
          "Izquierdo": {
            "Valor": 36,
            "Izquierdo": null,
            "Derecho": null
          },
          "Derecho": {
            "Valor": 28,
            "Izquierdo": null,
            "Derecho": null
          }
        },
        "Derecho": {
          "Valor": 58,
          "Izquierdo": {
            "Valor": 1,
            "Izquierdo": null,
            "Derecho": null
          },
          "Derecho": {
            "Valor": 5,
            "Izquierdo": null,
            "Derecho": null
          }
        }
      }
    }
  },
  "Valor1": 64,
  "Valor2": 59
}



Response

"El antecesor comun entre '64' y  '59' es: '62'"
