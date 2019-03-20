Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

#
#	.  Open paytm.com website in browser.
#	2.  Validate 'Mobile','Electricity','DTH','Metro' optios are available.
#	3.  Click 'Mobile' option and validate ' https://paytm.com/recharge' .
#	4. Enter Mobile number,select Operator,state and enter the Amount .
#	5. Click on 'Proceed to Recharge' then validate ' https://paytm.com/coupons'.
#	6. Click on 'Proceed to Pay'.

@mytag
Scenario: open Paytm website
	Given Open paytm web browser.
	When In paytm website there should be Mobile,Electricity,DTH,Metro
	Then check if the elements are present
Scenario: Do Paytm Recharge
	Given in paytm website select 'Mobile' option
	And clicked Mobile 
	And Later Enter the 'Mobile number'
	And Enter the Amount
	When Clicked on proceed to recharge
	Then it should redirect to 'https://paytm.com/coupons'

