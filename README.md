# Excercise 1 STRINGS
**IMPORTANT** this exercise is based on netcore 2.2 environment, the following instructions do not include how to setup your environment. Please refer to the [official documentation](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install)

Restore packages
```
cd ExerciseStrings
dotnet restore
```

Run application
```
cd ExerciseStrings
dotnet run
```

Run tests
```
cd ..
cd TestExerciseStrings
dotnet test
```

# Erercise 2 SALES
**IMPORTANT** this exercise is based on netcore 2.2 environment, the following instructions do not include how to setup your environment. Please refer to the [official documentation](https://dotnet.microsoft.com/learn/dotnet/hello-world-tutorial/install)

Restore packages
```
cd AWSLambda1
dotnet restore
```

Run application
```
cd AWSServerless1
dotnet run
```

Run tests
```
cd ..
cd CalculateSalesTaxesTests
dotnet test
```

**IMPORTANT** as an extra this exercise has been wrap in an Amazon AWS Lambda Serverless container and deployed on a test environment on Amazon AWS, it is possible to test live features on https://xgbtd6ys0b.execute-api.eu-west-1.amazonaws.com/Prod 

## Test API Endpoint with a REST Client
you can test locally or using the above live test link

HTTP VERB: POST
ENDPOINT: [local or live url]/api/calculatesalestaxes

BODY (from test 1):
```
{
    "items": [
      {
        "name": "book",
        "isImported": false,
        "category": 0,
        "unitPrice": 12.49,
        "quantity": 2
      },
      {
        "name": "music CD",
        "isImported": false,
        "category": 3,
        "unitPrice": 14.99,
        "quantity": 1
      },
      {
        "name": "chocolate bar",
        "isImported": false,
        "category": 1,
        "unitPrice": 0.85,
        "quantity": 1
      }
    ]
  }
```

# Premium Exercise!!
## Angular client

Whether the angular client was not in the original scope, it sounds good to provide a quick front end implementation for this service.

Install dependencies
```
npm install -g @angular/cli
```

Run the client
```
ng serve
```

ENOJY!
LF