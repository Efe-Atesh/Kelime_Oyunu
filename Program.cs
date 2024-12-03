using System;
using System.Collections.Generic;

List<string> kelimeler = new List<string>
{
    "art", "account", "achievement", "activity", "add", "afraid", "again",
    "age", "aggressive", "aid", "airport", "alive", "all", "alternative",
    "anger", "angry", "animal", "apartment", "apple", "application", "area",
    "arm", "army", "author", "available", "average", "award", "baby",
    "backpack", "bad", "bag", "ball", "bathroom", "battery", "battle", "beach",
    "beautiful", "bed", "bedroom", "before", "big", "bird", "birthday",
    "blanket", "blue", "border", "bottle", "box", "brain", "bread",
    "breakfast", "brother", "brown", "bus", "button", "buy", "carpet",
    "castle", "cave", "deaf", "decline", "deduce", "delusion", "demolition",
    "dentist", "edit", "economy", "exit", "effective", "emergency",
    "elephant", "emotion", "genius", "guest", "gravity", "glove", "gift",
    "ghost", "hair", "honey", "high", "hammer", "hand", "handsome", "happy",
    "hat", "injured", "image", "impossible", "incorrect", "information",
    "iron", "invisible", "key", "king", "kind", "kitchen", "knight",
    "monkey", "language", "laugh", "lawyer", "leader", "leaf", "leather",
    "leg", "lesson", "like", "lose", "lucky", "lunch", "loyalty", "memory",
    "milk", "minimum", "mistake", "money", "moon", "mother", "mountain",
    "mystery", "magic", "magnet", "nature", "neighbour", "news", "next",
    "packet", "pain", "paint", "pan", "paper", "password", "past", "peace",
    "personality", "photo", "picture", "pineapple", "plane", "place",
    "player", "poison", "pool", "power", "pregnant", "president", "price",
    "prize", "protect", "pull", "puppet", "puzzle", "pasta", "pillow",
    "queen", "quiz", "rabbit", "race", "rain", "rare", "ready", "read",
    "responsibility", "red", "record", "repair", "rent", "rich", "return",
    "roll", "room", "rose", "run", "safe", "sand", "school", "sea", "seat",
    "shoes", "shop", "short", "sit", "sky", "soft", "snow", "space", "speed",
    "star", "stone", "student"
};

List<string> cevaplar = new List<string>
{
    "sanat", "hesap", "başarı", "aktivite", "eklemek", "korkmak", "tekrar",
    "yaş", "agresif", "yardım etmek", "havalimanı", "canlı", "tüm",
    "alternatif", "öfke", "sinirli", "hayvan", "daire", "elma", "uygulama",
    "alan", "kol", "ordu", "yazar", "mevcut", "ortalama", "ödül", "bebek",
    "sırt çantası", "kötü", "çanta", "top", "banyo", "pil", "savaş", "sahil",
    "güzel", "yatak", "yatak odası", "önce", "büyük", "kuş", "doğum günü",
    "battaniye", "mavi", "sınır", "şişe", "kutu", "beyin", "ekmek",
    "kahvaltı", "erkek kardeş", "kahverengi", "otobüs", "düğme",
    "satın almak", "halı", "kale", "mağara", "sağır", "reddetmek",
    "sonuç çıkarmak", "aldatma", "yıkma", "dişçi", "düzenlemek", "ekonomi",
    "çıkış", "etkili", "acil", "fil", "duygu", "dahi", "misafir", "yer çekimi",
    "eldiven", "armağan", "hayalet", "saç", "bal", "yüksek", "çekiç", "el",
    "yakışıklı", "mutlu", "şapka", "yaralı", "görüntü", "imkansız", "yanlış",
    "bilgi", "demir", "görünmez", "anahtar", "kral", "nazik", "mutfak",
    "şovalye", "maymun", "dil", "gülmek", "avukat", "lider", "yaprak",
    "deri", "bacak", "ders", "beğenmek", "kaybetmek", "şanslı", "öğle yemeği",
    "sadakat", "hafıza", "süt", "en az", "hata", "para", "ay", "anne",
    "dağ", "gizemli", "büyü", "mıknatıs", "doğa", "komşu", "haber",
    "bir sonraki", "paket", "acı", "boyamak", "tava", "kağıt", "parola",
    "geçmiş", "barış", "kişilik", "fotoğraf", "resim", "ananas", "uçak",
    "yer", "oyuncu", "zehir", "havuz", "güç", "hamile", "başkan", "fiyat",
    "ödül", "korumak", "çekmek", "kukla", "bulmaca", "makarna", "yastık",
    "kraliçe", "test", "tavşan", "yarış", "yağmur", "nadir", "hazır",
    "okumak", "sorumluluk", "kırmızı", "kayıt", "onarmak", "kiralamak",
    "zengin", "geri dönmek", "yuvarlanmak", "oda", "gül", "koşmak",
    "güvenli", "kum", "okul", "deniz", "koltuk", "ayakkabı", "dükkan",
    "kısa", "oturmak", "hava", "yumuşak", "kar", "uzay", "hız", "yıldız",
    "taş", "öğrenci"
};

Random rnd = new Random();

int turdakiSoruSayisi = 10;
bool ikinciTur = false;
List<int> yanlisCevapVerdigimizSorular = new List<int> { };
int dogru = 0;
int yanlis = 0;
int dogru2 = 0;
int yanlis2 = 0;

sorukismi:

for (int suankiSoru = 0; suankiSoru < turdakiSoruSayisi; suankiSoru++) // tur / el / maç 
{
    int[] suanki_cevaplar = new int[4];
    int soruIndex = rnd.Next(0, kelimeler.Count);

    if (yanlisCevapVerdigimizSorular.Count > 0 && ikinciTur)
    {
        soruIndex = yanlisCevapVerdigimizSorular[suankiSoru];
    }

    for (int i = 0; i < 3; i++)
    {
        int rastgele_cevap_index = rnd.Next(0, cevaplar.Count);
        if (Array.Exists(suanki_cevaplar, x => x == rastgele_cevap_index))
        {
            i--;
            continue;
        }
        else
        {
            suanki_cevaplar[i] = rastgele_cevap_index;
        }
    }

    if (Array.Exists(suanki_cevaplar, x => x == soruIndex))
    {
        int rastgele_cevap_index;
        do
        {
            rastgele_cevap_index = rnd.Next(cevaplar.Count);

            suanki_cevaplar[3] = rastgele_cevap_index;
        } while (Array.Exists(suanki_cevaplar, x => x == rastgele_cevap_index));
    }
    else
    {
        suanki_cevaplar[3] = soruIndex;
    }

    Array.Sort(suanki_cevaplar);
    Console.WriteLine($"Kelime : {kelimeler[soruIndex]}\n");

    Console.WriteLine("");
    for (int i = 0; i < suanki_cevaplar.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {cevaplar[suanki_cevaplar[i]]}\n");
    }
    Console.WriteLine("");

    Console.Write("Cevap : ");
    int verilen_cevap = Convert.ToInt32(Console.ReadLine());

    if (cevaplar[suanki_cevaplar[verilen_cevap - 1]].Equals(cevaplar[soruIndex]))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Doğru Cevap!\n");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();
        

        if (ikinciTur)
            dogru2++;
        else
            dogru++;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Yanlış Cevap!\n");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();
        ;
        if (ikinciTur)
            yanlis2++;
        else
            yanlis++;
        yanlisCevapVerdigimizSorular.Add(soruIndex);
    }
}

if (ikinciTur)
{
    Console.WriteLine("Oyun bitmiştir...");
}
else
{
    ikinciTur = false;

    if (yanlis > 0)
    {
        Console.WriteLine("Yanlış yaptığınız sorular tekrar sorulacak...\n");

        turdakiSoruSayisi = yanlis;
        ikinciTur = true;

        goto sorukismi;
    }
}

Console.WriteLine($"Doğru Cevap sayınız {dogru} Yanlış Cevap Sayınız {yanlis}\n");

if (ikinciTur)
    Console.WriteLine($"2. Turdaki Doğru Cevap sayınız {dogru2} Yanlış Cevap Sayınız {yanlis2}\n");

Console.ReadKey();

