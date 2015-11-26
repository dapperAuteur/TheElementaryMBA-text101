using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	private enum States {newBiz, open, late, closed, view_promo_1, view_promo_2, view_promo_3, view_promo_4, accept_promo_1, accept_promo_2, accept_promo_3, accept_promo_4, read_landlord_email, call_landlord};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.newBiz;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.newBiz) {
			state_newBiz();
		}	else if (myState == States.open) {
				state_open();
		}	else if (myState == States.view_promo_1) {
				state_promo_1();
		}	else if (myState == States.view_promo_2) {
				state_promo_2();
		}	else if (myState == States.read_landlord_email) {
				state_read_landlord_email();
		}	else if (myState == States.call_landlord) {
				state_call_landlord();
		}
	}
	
	void state_newBiz () {
		text.text = "You’re the business manager of a health foods brand called TheBetterTreat. " +
			"TheBetterTreat produces delicious and healthy frozen treats. It's Thanksgiving morning " +
			"and you're tired from working late last night and then meeting friends for a late dinner.\n\n " +
			"Press O to Open Store, C to Close Store for the day (Keep Closed) and L to Open Store Late: ";
		if (Input.GetKeyDown(KeyCode.O))	{
			myState = States.open;
		}	else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closed;
		}	else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.late;
		}
	}
	
	void state_open () {
		text.text = "You open shop and read your emails. Their are 2 emails from Peddler's Sons that say " +
			"'Urgent Promotion' in the subject line. The third email is from your landlord. " +
			"Peddler’s Sons, your supplier, sent two promotional emails.\n\n " +
			"Press 'F1' to View Promo 1, 'F2' to View Promo 2, L to read the landlord's email " +
			"and W to Wait and start making popsicles immediately: ";
		if (Input.GetKeyDown(KeyCode.W))	{
			myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{
			myState = States.view_promo_1;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.F2))	{
				myState = States.view_promo_2;	//show promo 2
		}	else if (Input.GetKeyDown(KeyCode.L))	{
				myState = States.read_landlord_email;	//show landlord email
		}	
	}
	
	void state_promo_1 () { //add accept promotion 1 or 2,
		text.text = "The first promotion is $100 for 200 pounds of strawberries. You can make 10,000 " +
			"strawberry popsicles with the strawberries. Producing strawberry popsicles and selling them will " +
			"produce a $0.10 profit for each unit sold. \n\n " +
			"Press 'F2' to View Promotion 2, L to read the email from your landlord and W to Wait on reviewing the " +
			"emails and start making popsicles immediately: ";
		if (Input.GetKeyDown(KeyCode.W))	{
			myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F2))	{
				myState = States.view_promo_2;	//show promo 2
		}	else if (Input.GetKeyDown(KeyCode.L))	{
				myState = States.read_landlord_email;	//show landlord email
		}	
	}
	
	void state_promo_2 () { //add accept promotion 1 or 2
		text.text = "The second promotion is $200 for 375 pounds of oranges. You can make 7,500 " +
			"orange creamsicles with the oranges. Producing orange creamsicles and selling them will " +
			"produce a $0.25 profit for each unit sold. \n\n " +
			"Press 'F1' to View Promotion 1, L to read the email from your landlord , and W to Wait on " +
			"reviewing the emails and start making popsicles immediately: ";
		if (Input.GetKeyDown(KeyCode.W))	{
			myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.P))	{
				myState = States.view_promo_1;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.L))	{
				myState = States.read_landlord_email;	//show landlord email
		}	
	}
	
	void state_read_landlord_email () { //add accept promotion 1 or 2
			text.text = "YOUR DEPOSIT CHECK BOUNCED! I WANT A CASHIERS CHECK BY THE END OF BUSINESS OR YOU'RE " +
			"BUSINESS IS DONE. I'LL SELL YOUR EQUIPMENT FOR PENNIES ON THE DOLLAR AND YOU'RE NAME WILL BE MUDD " +
			"IN THIS TOWN! \n\n " +
			"Press U to Call the Landlord, 'F1' to View Promotion 1, 'F2' to View Promotion 2 and W to Wait on reviewing " +
			"the emails and start making popsicles immediately: ";
		if (Input.GetKeyDown(KeyCode.W))	{
			myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{
				myState = States.view_promo_1;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.F2))	{
				myState = States.view_promo_2;	//show promo 2
		}	
	}
	
	void state_call_landlord () { //create story/convo with angry landlord
			text.text = "YOUR DEPOSIT CHECK BOUNCED! I WANT A CASHIERS CHECK BY THE END OF BUSINESS OR YOU'RE " +
			"BUSINESS IS DONE. I'LL SELL YOUR EQUIPMENT FOR PENNIES ON THE DOLLAR AND YOU'RE NAME WILL BE MUDD " +
			"IN THIS TOWN! \n\n " +
			"Press U to Call the Landlord, 'F1' to View Promotion 1, 'F2' to View Promotion 2 and W to Wait on reviewing " +
			"the emails and start making popsicles immediately: ";
		if (Input.GetKeyDown(KeyCode.W))	{
			myState = States.newBiz;	//if you choose 'N' give option to read the inventory that needs to be restocked on the board.
		}	else if (Input.GetKeyDown(KeyCode.F1))	{
				myState = States.view_promo_1;	//show promo 1
		}	else if (Input.GetKeyDown(KeyCode.F2))	{
				myState = States.view_promo_2;	//show promo 2
		}	
	}
}
