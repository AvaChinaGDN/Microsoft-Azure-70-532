#### 2. Deployment Slots

![ds](images/2/1.png)

![ds](images/2/2.png)

![ds](images/2/3.png)

![ds](images/2/4.png)

![ds](images/2/5.png)

![ds](images/2/6.png)

![ds](images/2/7.png)

![ds](images/2/8.png)

![ds](images/2/9.png)

![ds](images/2/10.png)

![ds](images/2/11.png)

![ds](images/2/12.png)

![ds](images/2/13.png)

![ds](images/2/14.png)

![ds](images/2/15.png)

![ds](images/2/16.png)

![ds](images/2/17.png)

![ds](images/2/18.png)

![ds](images/2/19.png)

![ds](images/2/20.png)

![ds](images/2/21.png)

![ds](images/2/22.png)

![ds](images/2/23.png)

![ds](images/2/24.png)

![ds](images/2/25.png)

![ds](images/2/26.png)

![ds](images/2/27.png)

![ds](images/2/28.png)

![ds](images/2/29.png)

![ds](images/2/30.png)

![ds](images/2/31.png)

- Commands

```PowerShell
Add-AzureAccount
Get-AzureSubscription
New-AzureWebsite -Name "DemoWebSite-New" -Slot "uat"
Switch-AzureWebsiteSlot -Name "DemoWebSite-New" -Slot1 "staging" -Slot2 "uat"
```