# graphql-intro

Bare minimum GraphQL project with dotnet 6 minimal API and HotChocolate

## Steps
- Install latest version of HotChocolate.AspNetCore
- Add to container `builder.Services.AddGraphQLServer().AddQueryType<Query>();`
- Use `app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});` after `app.UseRouting();`
- Run project and navigate to `/graphql`
- Javascript client should send post request wrapping payload with `JSON.stringify`

## See Program.cs
```cs
using API.GraphQL;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();
```

## Sample Javascript client request

```js
$.ajax({url: "http://localhost:9000/graphql",
  contentType: "application/json",type:'POST',
  data: JSON.stringify({ query:`{
	 sayHello(name:"${name}")}`
  }),
  success: function(result) {
	 console.log(JSON.stringify(result))
	 $("#SayhelloDiv").html("<h1>"+result.data.sayHello +"</h1>");
  }
});

```
