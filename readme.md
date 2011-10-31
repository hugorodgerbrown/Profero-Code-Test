# Profero Interview Coding Test #
## Setup: ##
Open Profero.Interview\Profero.Interview.sln
## Scenario: ##
The existing Profero.Interview shopping cart (hit F5 in Visual Studio to see it) allows you to add and remove items. As you add each item you can set its Shipping method.
The available shipping options are stored in App_Data\Shipping.xml.
## Objectives: ##
1. Add a new Shipping Option to the application code. The Shipping Option should behave the same as the PerRegion Option except that if there are 2 or more items in the basket from the same Supplier and Region, 50p should be deducted from the shipping of each. Keep in mind the ability to change the parameters.
2. Write a unit test for the new code.
3. Form some opinions about how the code has been put together for discussion. Note that we are not looking for any particular criticisms (there are no "trick" mistakes, though there may be some genuine ones!).

## Time limit: ##
You have 45 minutes. It may not take this long so if you finished earlier just give us a buzz and let us know.
## Tips: ##

- App_Data\Shipping.xml is created with the CreateSampleData unit test. You should add to this to create your extended version of this file.
- Don't forget to add any new Shipping types to the KnownTypes method on ShippingBase.
- The Controller action used for the page is the Index action on the HomeController.

Good luck! Any problems or questions don't hesitate to ask.
