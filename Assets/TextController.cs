using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	private enum States {
		newBiz, open, late, closed, closed_confirm, promo_1, promo_1_l, promo_2, promo_2_l, accept_promo, win, win_p, win_lose,
		read_landlord_email, read_landlord_email_p, read_landlord_email_5, call_landlord, pay_landlord, work, work_l, open5, open8,
		open5_l, open8_l, closed_email, celebrate, call_landlord_p, call_landlord_5, closed_confirm_p, quit};
			
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.newBiz;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
			if 		(myState == States.newBiz) 					{newBiz();
		}	else if (myState == States.open) 					{open();
		}	else if (myState == States.promo_1) 				{promo_1();
		}	else if (myState == States.promo_2) 				{promo_2();
		}	else if (myState == States.accept_promo) 			{accept_promo();
		}	else if (myState == States.win) 					{win();
		}	else if (myState == States.win_lose) 				{win_lose();
		}	else if (myState == States.win_p) 					{win_p();
		}	else if (myState == States.promo_1_l) 				{promo_1_l();
		}	else if (myState == States.promo_2_l) 				{promo_2_l();
		}	else if (myState == States.read_landlord_email) 	{read_landlord_email();
		}	else if (myState == States.read_landlord_email_p) 	{read_landlord_email_p();
		}	else if (myState == States.read_landlord_email_5) 	{read_landlord_email_5();
		}	else if (myState == States.call_landlord) 			{call_landlord();
		}	else if (myState == States.call_landlord_p) 		{call_landlord_p();
		}	else if (myState == States.call_landlord_5) 		{call_landlord_5();
		}	else if (myState == States.late) 					{late();
		}	else if (myState == States.closed) 					{closed();
		}	else if (myState == States.open5) 					{open5();
		}	else if (myState == States.open8) 					{open8();
		}	else if (myState == States.open5_l) 				{open5_l();
		}	else if (myState == States.open8_l) 				{open8_l();
		}	else if (myState == States.work) 					{work();
		}	else if (myState == States.work_l) 					{work_l();
		}	else if (myState == States.closed_email) 			{closed_email();
		}	else if (myState == States.closed_confirm)			{closed_confirm();
		}	else if (myState == States.closed_confirm_p)		{closed_confirm_p();
		}	else if (myState == States.quit)					{quit();
		}	else if (myState == States.pay_landlord)			{pay_landlord();
		}	else if (myState == States.celebrate)				{celebrate();
		}
	}
	#region State handler methods
	void newBiz () {
		text.text = "You’re the business manager of TheBetterTreat " +
			"health foods brand. TheBetterTreat produces delicious and healthy frozen treats. It's Thanksgiving morning " +
			"and you're tired from working late last night and then meeting friends for a late dinner. \n\n" +
			"Press 'O' to Open Store, 'C' to Close Store for the day (Keep Closed) and 'T' to Open Store Late: ";
			if 		(Input.GetKeyDown(KeyCode.O))	{myState = States.open;
		}	else if (Input.GetKeyDown(KeyCode.C)) 	{myState = States.closed;
		}	else if (Input.GetKeyDown(KeyCode.T)) 	{myState = States.late;
		}
	}
	
	void open () {
		text.text = "You open shop and read your emails. There are 2 emails from Peddler's Sons that say " +
			"'Urgent Promotion' in the subject line. Peddler’s Sons is a produce distributor and your supplier. " +
			"The third email is from your landlord. \n\n" +
			"Press 'F1' to View Promo 1, 'F2' to View Promo 2, 'L' to read the landlord's email " +
			"and W to Work and start making popsicles immediately: ";
			if 		(Input.GetKeyDown(KeyCode.W))	{myState = States.work;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{myState = States.promo_1;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.F2))	{myState = States.promo_2;	//show promo 2
		}	else if (Input.GetKeyDown(KeyCode.L))	{myState = States.read_landlord_email;	//show landlord email
		}	
	}
	
	void work() {	//create story and scenario
		text.text = "You turn on the Super Fast Popsicle Freezer because it takes 1 hour for it to get " +
			"ready freeze popsicles Super Fast. While that's happening you decide to go to the Farmer's " +
			"Market and buy strawberries for your delicious strawberry popsicle recipe. \n\n" +
			"Press 'F5' to Check Your Email at 5pm, Press 'F8' to Check Your Email at 8pm, and 'I': " +
			"to Ignore Emails Today: ";
			if (Input.GetKeyDown(KeyCode.F5))		{myState = States.open5;	//show work option
		}	else if (Input.GetKeyDown(KeyCode.F8))	{myState = States.open8;	//show work option
		}	else if (Input.GetKeyDown(KeyCode.I))	{myState = States.closed_confirm;	//show work option
		}	
	}
	
	void work_l() {	//create story and scenario
		text.text = "You turn on the Super Fast Popsicle Freezer because it takes 1 hour for it to get " +
			"ready freeze popsicles Super Fast. While that's happening you decide to go to the Farmer's " +
			"Market and buy strawberries for your delicious strawberry popsicle recipe. \n\n" +
			"Press 'F5' to Check Your Email at 5pm, Press 'F8' to Check Your Email at 8pm, and 'I': " +
			"to Ignore Emails Today: ";
			if (Input.GetKeyDown(KeyCode.F5))		{myState = States.open5_l;	//show work option
		}	else if (Input.GetKeyDown(KeyCode.F8))	{myState = States.open8_l;	//show work option
		}	else if (Input.GetKeyDown(KeyCode.I))	{myState = States.closed_confirm;	//show work option
		}	
	}
	
	void promo_1 () { //add accept promotion 1 or 2,
		text.text = "The first promo is $100 for 200 pounds of strawberries. You can make 10,000 " +
			"strawberry popsicles with the strawberries. Producing strawberry popsicles and selling them will " +
			"produce a $0.10 profit for each unit sold. \n\n" +
			"Press 'F3' to accept Promo 1 'F2' to View Promo 2, 'L' to read the email from your landlord " +
			"and 'W' to Work and start making popsicles immediately: ";
			if 		(Input.GetKeyDown(KeyCode.W))	{myState = States.work;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F2))	{myState = States.promo_2;	//show promo 2
		}	else if (Input.GetKeyDown(KeyCode.L))	{myState = States.read_landlord_email;	//show landlord email
		}	else if (Input.GetKeyDown(KeyCode.F3))	{myState = States.accept_promo;	//show landlord email
		}	
	}
	
	void promo_1_l () { //add accept promotion 1 or 2,
		text.text = "The first promo is $100 for 200 pounds of strawberries. You can make 10,000 " +
			"strawberry popsicles with the strawberries. Producing strawberry popsicles and selling them will " +
			"produce a $0.10 profit for each unit sold. \n\n" +
			"Press 'F3' to accept Promo 1 'F2' to View Promo 2, " +
			"and 'W' to Work and start making popsicles immediately: ";
			if 		(Input.GetKeyDown(KeyCode.W))	{myState = States.work_l;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F2))	{myState = States.promo_2_l;	//show promo 2
		}	else if (Input.GetKeyDown(KeyCode.F3))	{myState = States.win;	//show landlord email
		}	
	}
	
	void accept_promo () { //add accept promotion 1 or 2, celebrate
		text.text = "Peddler's Sons delivers the product and they're delicious. " +
			"You make the best batch you've ever made. " +
			"You call your family and they want you to come home and celebrate. \n\n" +
			"Press 'F7' to Go Home and Celebrate and 'L' to read the email from your landlord ";
			if 		(Input.GetKeyDown(KeyCode.F7))	{myState = States.celebrate;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.L))	{myState = States.read_landlord_email_p;	//show landlord email
		}	
	}
	
	void win () { //add accept promotion 1 or 2, celebrate
		text.text = "Peddler's Sons delivers the product and they're delicious. " +
			"You make the best batch you've ever made. You call your family and they want you to come home and celebrate. " +
			"You Win! \n\n" +
			"Press 'P' to Play Again and 'Q' to Quit ";
			if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.Q))	{myState = States.quit;	//show landlord email
		}	
	}
	
	void promo_2 () { //add accept promotion 1 or 2
		text.text = "The second promo is $200 for 375 pounds of oranges. You can make 7,500 " +
			"orange creamsicles with the oranges. Producing orange creamsicles and selling them will " +
			"produce a $0.25 profit for each unit sold. \n\n" +
			"Press 'F3' to accept Promo 2, 'F1' to View Promo 1, 'L' to read the email from your landlord , and 'W' to Work " +
			"and start making popsicles immediately: ";
			if 		(Input.GetKeyDown(KeyCode.W))	{myState = States.work;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{myState = States.promo_1;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.L))	{myState = States.read_landlord_email;	//show landlord email
		}	else if (Input.GetKeyDown(KeyCode.F3))	{myState = States.accept_promo;	//show landlord email
		}	
	}
	
	void promo_2_l () { //add accept promotion 1 or 2
		text.text = "The second promo is $200 for 375 pounds of oranges. You can make 7,500 " +
			"orange creamsicles with the oranges. Producing orange creamsicles and selling them will " +
			"produce a $0.25 profit for each unit sold. \n\n" +
			"Press 'F3' to accept Promo 2, 'F1' to View Promo 1, 'L' to read the email from your landlord , and 'W' to Work " +
			"and start making popsicles immediately: ";
			if 		(Input.GetKeyDown(KeyCode.W))	{myState = States.work_l;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{myState = States.promo_1;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.F3))	{myState = States.win;	//show landlord email
		}	
	}
	
	void celebrate () { //add accept promotion 1 or 2,
		text.text = "You take the family some of your delicious product and they love it. " +
			"The entire family is happy to see you because you rarely get to see them. You wake up the next day and " +
			"arrive at the shop and the locks are changed. The landlord didn't get his money and sold your equipment.  \n\n" +
			"Press 'I' to continue: ";
			if 		(Input.GetKeyDown(KeyCode.I))	{myState = States.closed_confirm;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}
	}
	
	void read_landlord_email () { //add call Landlord & ignore Landlord
			text.text = "YOUR DEPOSIT CHECK BOUNCED! I WANT A CASHIERS CHECK BY THE END OF BUSINESS OR YOU'RE " +
			"BUSINESS IS DONE. I'LL SELL YOUR EQUIPMENT FOR PENNIES ON THE DOLLAR AND YOU'RE NAME WILL BE MUDD " +
			"IN THIS TOWN! \n\n" +
			"Press 'U' to Call the Landlord, 'F1' to View Promo 1, 'F2' to View Promo 2 and 'W' to Work " +
			"and start making popsicles immediately: ";
			if 		(Input.GetKeyDown(KeyCode.U))	{myState = States.call_landlord;//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{myState = States.promo_1;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.F2))	{myState = States.promo_2;	//show promo 2
		}	else if (Input.GetKeyDown(KeyCode.W))	{myState = States.work_l;	//show promo 2
		}
	}
	
	void read_landlord_email_p () { //add call Landlord & ignore Landlord
		text.text = "YOUR DEPOSIT CHECK BOUNCED! I WANT A CASHIERS CHECK BY THE END OF BUSINESS OR YOU'RE " +
			"BUSINESS IS DONE. I'LL SELL YOUR EQUIPMENT FOR PENNIES ON THE DOLLAR AND YOU'RE NAME WILL BE MUDD " +
			"IN THIS TOWN! \n\n" +
			"Press 'U' to Call the Landlord or 'I' to Ignore the landlord's email: ";
			if 		(Input.GetKeyDown(KeyCode.U))	{myState = States.call_landlord_p;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.I))	{myState = States.closed_confirm_p;	//show promo 1
		}
	}
	
	void read_landlord_email_5 () { //add call Landlord & ignore Landlord
		text.text = "YOUR DEPOSIT CHECK BOUNCED! I WANT A CASHIERS CHECK BY THE END OF BUSINESS OR YOU'RE " +
			"BUSINESS IS DONE. I'LL SELL YOUR EQUIPMENT FOR PENNIES ON THE DOLLAR AND YOU'RE NAME WILL BE MUDD " +
			"IN THIS TOWN! \n\n" +
			"Press 'U' to Call the Landlord or 'I' to Ignore the landlord's email: ";
			if 		(Input.GetKeyDown(KeyCode.U))	{myState = States.call_landlord_5;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.I))	{myState = States.closed_confirm;	//show promo 1
		}
	}
	
	void call_landlord () { //create story/convo with angry landlord
			text.text = "I DON'T WANT TO TALK. I WANT MY MONEY!: \n\n" +
			"Press 'Y' to Pay the Landlord, 'I' to Ignore the Landlord and got to work making popsicles.";
			if 		(Input.GetKeyDown(KeyCode.Y))	{myState = States.pay_landlord;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.I))	{myState = States.closed_confirm;	//show promo 1
		}	
	}
	
	void call_landlord_p () { //create story/convo with angry landlord
			text.text = "I DON'T WANT TO TALK. I WANT MY MONEY!: \n\n" +
			"Press 'Y' to Pay the Landlord, 'I' to Ignore the Landlord and got to work making popsicles.";
			if 		(Input.GetKeyDown(KeyCode.Y))	{myState = States.win_p;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.I))	{myState = States.closed_confirm;	//show promo 1
		}	
	}
	
	void call_landlord_5 () { //create story/convo with angry landlord
			text.text = "I DON'T WANT TO TALK. I WANT MY MONEY!: \n\n" +
			"Press 'Y' to Pay the Landlord, 'I' to Ignore the Landlord and got to work making popsicles.";
			if 		(Input.GetKeyDown(KeyCode.Y))	{myState = States.win_lose;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.I))	{myState = States.closed_confirm;	//show promo 1
		}	
	}
	
	void win_lose () {
			text.text = "You pay the landlord then check your emails. The other two emails were also time sensitive. " +
			"You miss out on an opportunity to grow your business and save some money. \n\n" +
			"Game Over! \n\n" +
			"Press 'P' to Play Again and 'Q' to Quit ";
			if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.Q))	{myState = States.quit;	//show landlord email
		}
	}
	
	void pay_landlord () {
		text.text = "You pay the landlord and open shop. There are 2 emails from Peddler's Sons that say " +
			"'Urgent Promotion' in the subject line. \n\n" +
			"Press 'F1' to View Promo 1, 'F2' to View Promo 2, 'W' to Work and start making popsicles immediately: ";
			if 		(Input.GetKeyDown(KeyCode.W))	{myState = States.work_l;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{myState = States.promo_1_l;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.F2))	{myState = States.promo_2_l;	//show promo 2
		}	
	}
	
	void win_p () {
		text.text = "You pay the landlord and open shop. You have a great day of business the next day. \n\n" +
			"You Win! \n\n" +
			"Press 'P' to Play Again and 'Q' to Quit ";
			if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.Q))	{myState = States.quit;	//show landlord email
		}		
	}
	
	void late () { //create story for late scenario
			text.text = "You spend an extra two hours in bed this morning. You still need to get ready for the Friday after " +
			"the holiday. There's a Cash Mob coming that loves supporting local businesses. Your business is new and could " +
			"use the cash to jumpstart your dream. Do you want to go in at 12pm, 5pm, or 8pm? \n\n" +
			"Press 'F12' to go in at 12pm, 'F5' to go in at 5pm, 'F8' to go in at 8pm and 'C' to keep the shop closed start tomorrow: ";
			if 		(Input.GetKeyDown(KeyCode.F12))	{myState = States.open;	//show open at 12 scenario
		}	else if (Input.GetKeyDown(KeyCode.F5))	{myState = States.open5;	//show open at 5 scenario
		}	else if (Input.GetKeyDown(KeyCode.F8))	{myState = States.open8;	//show open at 8 scenario
		}	else if (Input.GetKeyDown(KeyCode.C))	{myState = States.closed;	//show closed scenario
		}
	}
	
	void open5 () { //create story for late scenario
			text.text = "You open shop at 4pm and read your emails. Their are 2 emails from Peddler's Sons that say " +
			"'Urgent Promotion' in the subject line. The third email is from your landlord. " +
			"Peddler’s Sons, your supplier, sent two promotional emails. \n\n" +
			"Press 'F1' to View Promo 1, 'F2' to View Promo 2, 'L' to read the landlord's email " +
			"and 'W' to Work and start making popsicles immediately: ";
			if 		(Input.GetKeyDown(KeyCode.W))	{myState = States.closed_confirm;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{myState = States.open5_l;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.F2))	{myState = States.open5_l;	//show promo 2
		}	else if (Input.GetKeyDown(KeyCode.L))	{myState = States.read_landlord_email_5;	//show landlord email
		}
	}
	
	void open5_l () { //create story for late scenario
			text.text = "You read your emails. They were all time sensitive and you missed the opportunity. \n\n" +
			"Game Over! \n\n" +
			"Press 'P' to Play Again, 'Q' to Quit: ";
			if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.Q))	{myState = States.quit;	//show promo 1
		}
	}
	
	void open8 () { //create story for late scenario
			text.text = "You open shop at 7pm and read your emails. Their are 2 emails from Peddler's Sons that say " +
			"'Urgent Promotion' in the subject line. The third email is from your landlord. " +
			"Peddler’s Sons, your supplier, sent two promotional emails. \n\n" +
			"Press 'F1' to View Promo 1, 'F2' to View Promo 2, 'L' to read the landlord's email " +
			"and 'W' to Work and start making popsicles immediately: ";
			if 		(Input.GetKeyDown(KeyCode.W))	{myState = States.closed_confirm;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{myState = States.open5_l;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.F2))	{myState = States.open5_l;	//show promo 2
		}	else if (Input.GetKeyDown(KeyCode.L))	{myState = States.open5_l;	//show landlord email
		}
	}
	
	void open8_l () { //create story for late scenario
			text.text = "At 8:30 pm you read your emails. Their are 2 emails from Peddler's Sons that say " +
			"'Urgent Promotion' in the subject line. The emails were time sensitive and you missed the opportunity to save. \n\n" +
			"Game Over! \n\n" +
			"Press 'P' to Play Again, 'Q' to Quit: ";
			if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.Q))	{myState = States.quit;	//show promo 1
		}
	}
	
	void closed () { //create story for late scenario
			text.text = "You decide to check your emails. Their are 2 emails from Peddler's Sons that say " +
			"'Urgent Promotion'. The third email is from your landlord. Peddler’s Sons, your supplier, " +
			"sent two promotional emails. \n\n" +
			"Press 'F1' to View Promo 1, 'F2' to View Promo 2, 'L' to read the landlord's email " +
			"and 'I' to ignore the emails and enjoy your day off: ";
			if 		(Input.GetKeyDown(KeyCode.I))	{myState = States.closed_confirm;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{myState = States.promo_1;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.F2))	{myState = States.promo_2;	//show promo 2
		}	else if (Input.GetKeyDown(KeyCode.L))	{myState = States.read_landlord_email;	//show landlord email
		}
	}
	
	void closed_email () { //create 
		text.text = "You decide to check your emails. Their are 2 emails from Peddler's Sons that say " +
			"'Urgent Promotion'. The third email is from your landlord. Peddler’s Sons, your supplier, " +
			"sent two promotional emails. \n\n" +
			"Press 'F1' to View Promo 1, 'F2' to View Promo 2, 'L' to read the landlord's email " +
			"'G' to Open the Shop Late and 'I' to ignore the emails and enjoy your day off: ";
			if 		(Input.GetKeyDown(KeyCode.I))	{myState = States.closed_confirm;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{myState = States.promo_1;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.F2))	{myState = States.promo_2;	//show promo 2
		}	else if (Input.GetKeyDown(KeyCode.G))	{myState = States.late;	//show landlord email
		}	else if (Input.GetKeyDown(KeyCode.L))	{myState = States.read_landlord_email;	//show landlord email
		}
	}
	
	void closed_confirm () { //create story for late scenario
			text.text = "You missed out on 2 opportunities to grow your business. More importantly you " +
			"ignored an important email from your landlord. The landlord changes the locks and sells your " +
			"equipment to make of for their losses. Then tells everyone you don't pay your bills. \n\n" +
			"GAME OVER! \n\n " +
			"Press 'P' to play again or 'Q' to quit: ";
			if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.Q))	{myState = States.quit;	//show promo 1
		}
	}
	
	void closed_confirm_p () { //create story for late scenario
			text.text = "You took advantage of a great opportunity to grow your business. But more importantly you " +
			"ignored an important email from your landlord. The landlord changes the locks and sells your " +
			"equipment to make of for their losses. Then tells everyone you don't pay your bills. \n\n" +
			"GAME OVER! \n\n " +
			"Press 'P' to play again or 'Q' to quit: ";
			if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.Q))	{myState = States.quit;	//show promo 1
		}
	}
	
	void quit () { //create story for late scenario
			text.text = "Thank You For Playing The Elementary MBA. " +
			"Please Share The Game & Experience With Your Friends. " +
			"Follow Us On Our Journey @ElementaryMBA & TheElementaryMBA.com \n\n" +
			"Press 'P' to play again or 'Q' to quit: ";
			if 		(Input.GetKeyDown(KeyCode.P))	{myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.Q))	{myState = States.quit;	//show promo 1
		}
	}
	#endregion
}
