//У нас есть кеш - N $ , мы хотим сохранить его от инфляции, кладем в банк
// и получаем раз в год M % , через сколько лет у нас получится 
//купить квартиру за K $ , при том , что цена квартиры также растет 
//на Q % если этот процент больше или равен N , то вывести в консоль безысходность 
using static System.Console;
Clear();

int cash = int.Parse(ReadLine()!);;
int percent = int.Parse(ReadLine()!);;
int price = int.Parse(ReadLine()!);;
int inflay = int.Parse(ReadLine()!);;
int i = 0;


if (inflay > percent)
{
    WriteLine("Безысходнось");
}
else
{
    while (cash < price)
    {
        cash += cash / 100 * percent;
        price += price / 100 * inflay;
        i++;

    }
WriteLine(i+" лет");
}


