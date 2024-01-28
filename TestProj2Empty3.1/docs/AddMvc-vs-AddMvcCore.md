# AddMvc vs AddMvcCore

Before deriving our class from Controller
![Alt text](image.png)

After inherting from Controller from `AspNetCore.Mvc`
![Alt text](image-1.png)

when AddMvc is used  
![Alt text](image-2.png)

When AddMvcCore is used  
We get error as MvcCore just contains the core mvc services instead of all services,
AddMvcCore is a subset of AddMvc (internally calls AddMvcCore) 