using System.Text;
using System.IO;
Console.Write("Введите строку, которую хотите зашифровать: ");
StringBuilder s = new StringBuilder(Console.ReadLine());
Console.Write("Введите ключ (один символ): ");
char keyChar = Convert.ToChar(Console.Read());
int key = (int)keyChar;
s = Vernam(s, key);
File.WriteAllText("vernam.txt", s.ToString());
Console.WriteLine(s);
s = Vernam(s, key);
Console.WriteLine(s);
static StringBuilder Vernam(StringBuilder s, int key)
{
    for (int i = 0; i < s.Length; i++)
    {
        //char letter = s[i];
        //int val = (int)letter ^ key;
        string binary = Convert.ToString((int)s[i] ^ key, 2);
        Console.Write(binary + " ");
        s[i] = Convert.ToChar((int)s[i] ^ key);
        //  s[i] = Convert.ToChar(val);
    }
    Console.WriteLine();
    return s;
}
//using System;
//using System.Text;
//using System.IO;
//using System.Security.Cryptography;
//try
//{
//    string original = "Here is some data to encrypt!";
//    // Создание экземпляра класс RijndaelManged для работы с AES (Rijndael)
//    using (RijndaelManaged myRijndael = new RijndaelManaged())
//    {
//        // генерация ключа
//        myRijndael.GenerateKey();
//        // генерация инициализирующего вектора
//        myRijndael.GenerateIV();
//        // шифрование строки в массив байт
//        byte[] encrypted = EncryptStringToBytes(original, myRijndael.Key, myRijndael.IV);
//        string hexString = BitConverter.ToString(encrypted).Replace("-", "");
//        File.WriteAllText("encryptedData.txt", hexString);
//        // расшифрование массива байт в строке
//        string roundtrip = DecryptStringFromBytes(encrypted, myRijndael.Key, myRijndael.IV);
//        // вывод исходных данных и зашифрованных
//        Console.WriteLine("Original:   {0}", original);
//        Console.WriteLine("Round Trip: {0}", roundtrip);
//    }
//    static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
//    {
//        // Check arguments.
//        if (plainText == null || plainText.Length <= 0)
//            throw new ArgumentNullException("plainText");
//        if (Key == null || Key.Length <= 0)
//            throw new ArgumentNullException("Key");
//        if (IV == null || IV.Length <= 0)
//            throw new ArgumentNullException("IV");
//        byte[] encrypted;
//        // Create an RijndaelManaged object
//        // with the specified key and IV.
//        using (RijndaelManaged rijAlg = new RijndaelManaged())
//        {
//            rijAlg.Key = Key;
//            rijAlg.IV = IV;

//            // Create an encryptor to perform the stream transform.
//            ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

//            // Create the streams used for encryption.
//            using (MemoryStream msEncrypt = new MemoryStream())
//            {
//                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
//                {
//                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
//                    {
//                        //Write all data to the stream.
//                        swEncrypt.Write(plainText);
//                    }
//                }
//                encrypted = msEncrypt.ToArray();
//            }
//        }
//        // Return the encrypted bytes from the memory stream.
//        return encrypted;
//    }
//    static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
//    {
//        // Check arguments.
//        if (cipherText == null || cipherText.Length <= 0)
//            throw new ArgumentNullException("cipherText");
//        if (Key == null || Key.Length <= 0)
//            throw new ArgumentNullException("Key");
//        if (IV == null || IV.Length <= 0)
//            throw new ArgumentNullException("IV");

//        // Declare the string used to hold
//        // the decrypted text.
//        string plaintext = null;

//        // Create an RijndaelManaged object
//        // with the specified key and IV.
//        using (RijndaelManaged rijAlg = new RijndaelManaged())
//        {
//            rijAlg.Key = Key;
//            rijAlg.IV = IV;

//            // Create a decryptor to perform the stream transform.
//            ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

//            // Create the streams used for decryption.
//            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
//            {
//                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
//                {
//                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
//                    {
//                        // Read the decrypted bytes from the decrypting stream
//                        // and place them in a string.
//                        plaintext = srDecrypt.ReadToEnd();
//                    }
//                }
//            }
//        }

//        return plaintext;
//    }
//}
//catch (Exception e)
//{
//    Console.WriteLine("Error: {0}", e.Message);
//}

//using System.Text;
//string s = @"1. Перечислить особенности создания и описания структур
//- структура является значимым, а не ссылочным типом данных, то
//есть экземпляр структуры хранит значения своих элементов, а не ссылки
//на них, и располагается в стеке, а не в хипе;
//- структура не может участвовать в иерархиях наследования, она
//может только реализовывать интерфейсы;
//- в структуре запрещено определять конструктор по умолчанию,
//поскольку он определен неявно и присваивает всем ее элементам
//значения по умолчанию (нули соответствующего типа);
//- в структуре запрещено определять деструкторы, поскольку это
//бессмысленно.
//Структура объявляется следующим образов: [атрибуты] [спецификаторы] struct имя_структуры [:интерфейсы] тело структуры [;]

//2. Выписать все возможности и особенности структур
//Спецификаторы структуры имеют такой же смысл, как и для класса,
//причем из спецификаторов доступа допускаются только public, internal и
//private (последний – только для вложенных структур).
//Интерфейсы, реализуемые структурой, перечисляются через запятую.
//Тело структуры может состоять из констант, полей, методов, свойств,
//событий, индексаторов, операций, конструкторов и вложенных типов.
//Правила их описания и использования аналогичны соответствующим
//элементам классов.
//Отличия структур от классов:
//- поскольку структуры не могут участвовать в иерархиях, для их
//элементов не могут использоваться спецификаторы protected и
//protected internal;
//- структуры не могут быть абстрактными (abstract), к тому же по
//умолчанию они бесплодны (sealed);
//- методы структур не могут быть абстрактными и виртуальными;
//переопределяться (то есть описываться со спецификатором
//override) могут только методы, унаследованные от базового класса
//object;
//- параметр this интерпретируется как значение, поэтому его
//можно использовать для ссылок, но не для присваивания;
//- при описании структуры нельзя задавать значения полей по
//умолчанию – это будет сделано в конструкторе по умолчанию,
//создаваемом автоматически (конструктор присваивает значимым полям
//структуры нули, а ссылочным – значение null).
//Примечание – к статическим полям это ограничение не относится.
//Когда одна структура присваивается другой, создается копия ее объекта.
//В этом заключается одно из главных отличий структуры от класса. Когда
//ссылка на один класс присваивается ссылке на другой класс, в итоге ссылка в
//левой части оператора присваивания указывает на тот же самый объект, что
//и ссылка в правой его части.
//А когда переменная одной структуры присваивается переменной другой
//структуры, создается копия объекта структуры из правой части оператора
//присваивания.

//3. К каким типам даных относятся структуры и в чем особенности таких типов
//Структура является значимым, а не ссылочным типом данных, то
//есть экземпляр структуры хранит значения своих элементов, а не ссылки
//на них, и располагается в стеке, а не в хипе;

//4. Перечислить особенности объявления перечислений. Как получить доступ к части перечисления?
//Для этого удобно воспользоваться перечисляемым типом данных, все
//возможные значения которого задаются списком целочисленных констант,
//например:
//enum Menu {Read, Write, Append, Exit}
//enum Радуга {Красный, Оранжевый, Желтый, Зеленый, Синий,
//Фиолетовый}
//Для каждой константы задается ее символическое имя. По умолчанию
//константам присваиваются последовательные значения типа int, начиная с
//0, но можно задать и собственные значения, например:
//enum Nums {two = 2, three, four, ten = 10,
//eleven, fifty = ten + 40};
//Константам three и four присваиваются значения 3 и 4, константе
//eleven – 11.
//Имена перечисляемых констант внутри каждого перечисления должны
//быть уникальными, а значения могут совпадать.
//Преимущество перечисления перед описанием именованных констант
//состоит в том, что связанные константы нагляднее; кроме того, компилятор
//выполняет проверку типов, а интегрированная среда разработки
//подсказывает возможные значения констант, выводя их список.

//5. Выписать все спецификаторы структур
//Спецификаторы структуры имеют такой же смысл, как и для класса,
//причем из спецификаторов доступа допускаются только public, internal и
//private (последний – только для вложенных структур).

//6. В чём разница массива экземпляра классов и массива экземпляра структур
//В том, что для массива из 100 экземпляров класса создается 101
//объект, а для массива структур – один объект.

//7. Как задать текущую дату и время (минимум 3 способа)
//DataTime.Now
//DataTime.UtcNow
//DataTime.Today";

//int iterator = 0;
//int row = 0, col = 0;
//Console.Write("Number of rows: ");
//int t = Convert.ToInt32(Console.ReadLine());
//while (true)
//{
//    if (iterator == s.Length)
//    {
//        break;
//    }
//    for (row = 0; row < t; row++, iterator++)
//    {
//        if (iterator == s.Length)
//        {
//            break;
//        }
//        //res[row, col] = s[iterator];
//    }
//    if (iterator == s.Length)
//    {
//        break;
//    }
//    col++;  
//    for(row = t-2; row > 0; row--, iterator++)
//    {
//        if (iterator == s.Length)
//        {
//            break;
//        }
//        col++;
//        col++;
//        //res[row, col++] = s[iterator];
//    }
//    if (iterator == s.Length)
//    {
//        break;
//    }
//}
//char[,] res = new char[t, col+1];
//iterator = 0;
//row = 0;
//int c = 0;
//while (true)
//{
//    if (iterator == s.Length)
//    {
//        break;
//    }
//    for (row = 0; row < t; row++, iterator++)
//    {
//        if (iterator == s.Length)
//        {
//            break;
//        }
//        res[row, c] = s[iterator];
//    }
//    if (iterator == s.Length)
//    {
//        break;
//    }
//    c++;
//    for (row = t - 2; row > 0; row--, iterator++)
//    {
//        if (iterator == s.Length)
//        {
//            break;
//        }
//        c++;
//        res[row, c++] = s[iterator];
//    }
//    if (iterator == s.Length)
//    {
//        break;
//    }
//}
//StringBuilder str = new StringBuilder(t*col);
//iterator = 0;
//for(int i = 0; i < t;i++)
//{
//    for(int j = 0; j  <= col; j++)
//    {
//        if (char.IsLetter(res[i,j]) || char.IsPunctuation(res[i,j]) || res[i,j] == ' ')
//            str.Append(res[i, j]);
//    }
//}
////Console.WriteLine(str.ToString());
//File.WriteAllText("shifr.txt", str.ToString());
