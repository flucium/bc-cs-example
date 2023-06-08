byte[] plain = System.Text.Encoding.UTF8.GetBytes("hello");
byte[] key = System.Text.Encoding.UTF8.GetBytes("0000011111222223");
byte[] aad = System.Text.Encoding.UTF8.GetBytes("aad");
byte[] nonce = System.Text.Encoding.UTF8.GetBytes("000001111122");
int macSize = 128;

AeadParameters aeadParameters = new AeadParameters(new KeyParameter(key), macSize, nonce);

GcmBlockCipher gcmBlockCipher = new GcmBlockCipher(new AesEngine());

// true: Encrypt
// false: Decrypt
gcmBlockCipher.Init(true, aeadParameters);

int osize = gcmBlockCipher.GetOutputSize(plain.Length);

byte[] cipher = new byte[osize];

int outOff = gcmBlockCipher.ProcessBytes(plain, 0, plain.Length, cipher, 0);

gcmBlockCipher.DoFinal(cipher, outOff);

Console.WriteLine(Convert.ToBase64String(cipher));
