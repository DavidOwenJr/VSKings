using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kings
{    
    public partial class Kings : Form
    {
        List<Card> game_deck;
        int card_pos = 0;

        public Kings()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            game_deck = initialize_deck(game_deck);
        }

//========================================================================================================================
//  Initialize an entire deck of cards (52)
//========================================================================================================================       
        public List<Card> initialize_deck(List<Card> new_deck)
        {
            List<Card> result_deck = new List<Card>();

        //Aces
            result_deck.Add(new Card(0, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\0.png"), "Ace", "Clubs"));
            result_deck.Add(new Card(1, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\1.png"), "Ace", "Hearts"));
            result_deck.Add(new Card(2, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\2.png"), "Ace", "Diamonds"));
            result_deck.Add(new Card(3, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\3.png"), "Ace", "Spades"));
        //Kings
            result_deck.Add(new Card(4, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\4.png"), "King", "Clubs"));
            result_deck.Add(new Card(5, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\5.png"), "King", "Diamonds"));
            result_deck.Add(new Card(6, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\6.png"), "King", "Hearts"));
            result_deck.Add(new Card(7, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\7.png"), "King", "Spades"));
        //Queens
            result_deck.Add(new Card(8, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\8.png"), "Queen", "Clubs"));
            result_deck.Add(new Card(9, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\9.png"), "Queen", "Diamonds"));
            result_deck.Add(new Card(10, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\10.png"), "Queen", "Spades"));
            result_deck.Add(new Card(11, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\11.png"), "Queen", "Hearts"));
        //Jacks
            result_deck.Add(new Card(12, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\12.png"), "Jack", "Clubs"));
            result_deck.Add(new Card(13, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\13.png"), "Jack", "Diamonds"));
            result_deck.Add(new Card(14, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\14.png"), "Jack", "Hearts"));
            result_deck.Add(new Card(15, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\15.png"), "Jack", "Spades"));
        //Tens
            result_deck.Add(new Card(16, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\16.png"), "Ten", "Clubs"));
            result_deck.Add(new Card(17, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\17.png"), "Ten", "Diamonds"));
            result_deck.Add(new Card(18, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\18.png"), "Ten", "Hearts"));
            result_deck.Add(new Card(19, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\19.png"), "Ten", "Spades"));
        //Nines
            result_deck.Add(new Card(20, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\20.png"), "Nine", "Clubs"));
            result_deck.Add(new Card(21, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\21.png"), "Nine", "Diamonds"));
            result_deck.Add(new Card(22, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\22.png"), "Nine", "Hearts"));
            result_deck.Add(new Card(23, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\23.png"), "Nine", "Spades"));
        //Eights
            result_deck.Add(new Card(24, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\24.png"), "Eight", "Clubs"));
            result_deck.Add(new Card(25, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\25.png"), "Eight", "Diamonds"));
            result_deck.Add(new Card(26, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\26.png"), "Eight", "Hearts"));
            result_deck.Add(new Card(27, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\27.png"), "Eight", "Spades"));
        //Sevens
            result_deck.Add(new Card(28, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\28.png"), "Seven", "Spades"));
            result_deck.Add(new Card(29, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\29.png"), "Seven", "Hearts"));
            result_deck.Add(new Card(30, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\30.png"), "Seven", "Diamonds"));
            result_deck.Add(new Card(31, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\31.png"), "Seven", "Clubs"));
        //Sixs
            result_deck.Add(new Card(32, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\32.png"), "Six", "Spades"));
            result_deck.Add(new Card(33, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\33.png"), "Six", "Hearts"));
            result_deck.Add(new Card(34, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\34.png"), "Six", "Diamonds"));
            result_deck.Add(new Card(35, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\35.png"), "Six", "Clubs"));     
        //Fives
            result_deck.Add(new Card(36, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\36.png"), "Five", "Spades"));
            result_deck.Add(new Card(37, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\37.png"), "Five", "Hearts"));
            result_deck.Add(new Card(38, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\38.png"), "Five", "Diamonds"));
            result_deck.Add(new Card(39, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\39.png"), "Five", "Clubs"));     
        //Fours
            result_deck.Add(new Card(40, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\40.png"), "Four", "Spades"));
            result_deck.Add(new Card(41, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\41.png"), "Four", "Hearts"));
            result_deck.Add(new Card(42, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\42.png"), "Four", "Diamonds"));
            result_deck.Add(new Card(43, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\43.png"), "Four", "Clubs"));
        //Threes
            result_deck.Add(new Card(44, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\44.png"), "Three", "Spades"));
            result_deck.Add(new Card(45, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\45.png"), "Three", "Hearts"));
            result_deck.Add(new Card(46, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\46.png"), "Three", "Diamonds"));
            result_deck.Add(new Card(47, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\47.png"), "Three", "Clubs"));
        //Twos
            result_deck.Add(new Card(48, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\48.png"), "Two", "Spades"));
            result_deck.Add(new Card(49, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\49.png"), "Two", "Hearts"));
            result_deck.Add(new Card(50, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\50.png"), "Two", "Diamonds"));
            result_deck.Add(new Card(51, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\51.png"), "Two", "Clubs"));
        //Jokers
            result_deck.Add(new Card(52, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\52.png"), "Joker", "Black"));
            result_deck.Add(new Card(53, Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\53.png"), "Joker", "Red"));

            result_deck = shuffle(result_deck);
            show_deck(result_deck);
            return result_deck;
        }

//========================================================================================================================
//  Shuffle the deck after start
//========================================================================================================================    
        public List<Card> shuffle(List<Card> initial)
        { 
            List<Card> temp = new List<Card>();
            Random generator = new Random();
            int index = 0;
            card_pos = 0;

            
            for (int i = 0; i < initial.Count; i++)
            {
                do
                {
                    index = generator.Next(0, initial.Count);
                }
                while (temp.Contains(initial[index]));
                temp.Add(initial[index]);
            }

            List<Card> result = new List<Card>();
            for (int i = 0; i < temp.Count; i++)
            {
                   result.Add(temp[i]);
                   result[i].set_pos(i);

            }
            curr_pos.Text = card_pos.ToString();
            return result;
        }

//========================================================================================================================
//  Shuffle the deck
//========================================================================================================================    
        private void shuffle_deck_Click(object sender, EventArgs e)
        {
            card_pos = 0;
            
            game_deck = initialize_deck(game_deck);
            curr_card.Image = game_deck[card_pos].get_image();
            curr_pos.Text = card_pos.ToString();

            curr_card.Image = Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\game_start.png");
            label1.Text = "Starting new game!";
            prev_card.Enabled = false;
            next_card.Enabled = true;
            shuffle_deck.Text = "Shuffle";

            show_deck(game_deck);
        }

//========================================================================================================================
//  Print Out the entire deck function
//========================================================================================================================       
        public void show_deck(List<Card> deck)
        {
            Console.WriteLine("=============THIS IS THE GAME DECK=============");
            for(int i=0; i<deck.Count(); i++)
            {
                Console.WriteLine(deck[i].get_pos()+"\t"+deck[i].get_value()+" of "+deck[i].get_suit());
            }
        }

//========================================================================================================================
//  Get drink rules
//======================================================================================================================== 
        public void get_rules(Card curr)
        {

        }

//========================================================================================================================
//  Draw the next card
//======================================================================================================================== 
        private void next_card_Click(object sender, EventArgs e)
        {
            prev_card.Enabled = true;
            if (card_pos <= game_deck.Count-1)
            {
                card_pos++;
                label1.Text = game_deck[card_pos].get_value() + " of " + game_deck[card_pos].get_suit();
                curr_card.Image = game_deck[card_pos].get_image();

                curr_pos.Text = card_pos.ToString();
            }
            else 
            {
                curr_card.Image = Image.FromFile("C:\\Users\\David.Owen\\Documents\\Visual Studio 2012\\Projects\\Kings\\Kings\\cards\\game_over.png");
                label1.Text = "Game Over!";
                shuffle_deck.Text = "New Game";
                next_card.Enabled = false;
            }
        }

        private void prev_card_Click(object sender, EventArgs e)
        {
            
            if (card_pos > 0)
            {
                card_pos--;
                prev_card.Enabled = true;
                next_card.Enabled = true;
                label1.Text = game_deck[card_pos].get_value() + " of " + game_deck[card_pos].get_suit();
                curr_card.Image = game_deck[card_pos].get_image();
                curr_pos.Text = card_pos.ToString();
                if (card_pos == 0)
                {
                    prev_card.Enabled = false;
                }
            }
            else
            {
                prev_card.Enabled = false;
            }
        }

    }
//========================================================================================================================
//  Card class
//      position    = position in deck
//      img         = actual image jpeg
//      value       = value of card (ace, king, queen, jack, ten, nine, etc)
//      suit        = suite of the card
//========================================================================================================================
    public class Card
    {
        public int position;
        Image img;
        string value;
        string suit;

        //Constructor
        public Card(int _pos, Image _img, string _value, string _suit)
        {
            position = _pos;
            img = _img;
            value = _value;
            suit = _suit;
        }
        //Setters
        public void set_image(Image _img) { img = _img; }
        public void set_value(string _val) { value = _val; }
        public void set_suit(string _suit) { suit = _suit; }
        public void set_pos(int _pos) { position = _pos; }
        //Getters
        public Image get_image() { return img; }
        public string get_value() { return value; }
        public string get_suit() { return suit; }
        public int get_pos() { return position; }

        //Helpers
        public int CompareTo(Card other)
        {
            if (other.get_pos() == this.get_pos())
            {
                return 1;
            }
            else
                return 0;
        }
        //Exceptions
        internal void set_image()
        {
            throw new NotImplementedException();
        }
    }

}

