#### 4. Site Settings

![ss](images/4/1.png)

![ss](images/4/2.png)

![ss](images/4/3.png)

![ss](images/4/4.png)

![ss](images/4/5.png)

![ss](images/4/6.png)

![ss](images/4/7.png)

![ss](images/4/8.png)

![ss](images/4/9.png)

![ss](images/4/10.png)

![ss](images/4/11.png)

![ss](images/4/12.png)

![ss](images/4/13.png)

![ss](images/4/14.png)

![ss](images/4/15.png)

![ss](images/4/16.png)

- Extract azure site settings

```
@Environment.GetEnvironmentVariable("APPSETTING_MyAppVariable")
@Environment.GetEnvironmentVariable("SQLAZURECONNSTR_MyConnStr")
```

- Extract local site settings

```
@System.Configuration.ConfigurationManager.AppSettings["MyAppVariable"]
@System.Configuration.ConfigurationManager.ConnectionStrings["MyConnStr"]
```