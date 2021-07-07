# Julio05

## Tecnologias antiguas

CORBA, etc. RPC, etc.

## Web Services.

Que hace un web service?. Permite la comuninacion de datos entre diferentes sistemas (usando una pagina web).

## SOAP SOAP es un standard. Existen dos estandard, 1.1 y 1.2 (2.0), y el soap trabaja con XML y WSDL

* Un cliente envia una informacion (un XML) hacia un web service.
* El Web service responde con un XML.

El formato del XML es un estandard, asi que tiene una forma especifica de escribirlo.

## Como crear un (web service) SOAP

* Crear en el proyecto un archivo asmx
* (opcional) Cambiar el namespace
* Dentro de la clase agregar los metodos que quiero compartir. Esos metodos tienen que tener la anotacion [WEBMETHOD]
* Para poder crear un metodo, los datos tienen que ser serializables.  
Por ejemplo, si tengo una referencia circular, debo evitarlo con

        [XmlIgnore] // ASMX, WCF
        [JsonIgnore] // WCF Ajax
        [IgnoreDataMember] // WebApi

## Como conectarme.

* Dentro del proyecto, en el explorador de la solucion, y a Connected Services, y agregar la ruta donde esta el WSDL.
* Luego, eso va a generar todas las clases necesarias.

Luego, usar la clase que termina con SoapClient() o que termina con Client() (si es un web service SOAP)

```csharp
    using(var cliente=new WebServiceVehiculoSoapClient()) { 
        
    }
```


## Como probar el SOAP y WCF

https://www.soapui.org/downloads/soapui/


## WCF alternativa a SOAP

Windows Communication Foundation (WCF), es una copia de SOAP.

## Como crear uno?

1) Al proyecto, agregar un archivo del tipo WCF (no la version AJAX).
Luego, agregar los metodos a la clase (svc), y ademas agregar los metodos a compartir en la interface.


## Por que no usar XML?

* Porque usa mas espacio (en comparacion a JSON).
* Porque es mas pesado y no es facil de entender.
* Porque muchos programas y librerias no lo usan (no lo usa javascript o aplicaciones de celulares)

## JSON (Web service, Servicios Rest, Web Service Rest)

* Si el servicio usa todos los verbos, GET, POST, PUT y DELETE entonces se puede llamar RESTful.
* El servicio rest no tiene o usa WSDL.
* El servicio rest tiene un descriptor WADL (esto es tecnologia muerta) pero no es estandard y pocos programas lo usan.
* Otra alternativa de descriptor es OpenAPI, pero no es estandard y no todos los programas lo usan.


## WCF AJAX 

* Web Service REST
* Devuelve un XML o un JSON
* No usa WSDL (no es SOAP)
* Web Api lo reemplaza.

### Rest WCF AJAX

> http://localhost:9999/Cliente.svc/Listar

### WebApi

> http://localhost:9999/Cliente/ [GET]


## SignalR 

* Se usa para comunicacion de dos vias (lectura y escritura).
* Usa menos ancho de banda y tiene un menor lag.


## Los web services son clases de servicios con unas anotaciones especiales.










