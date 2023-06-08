
byte[] plain = System.Text.Encoding.UTF8.GetBytes("hello");
byte[] key = System.Text.Encoding.UTF8.GetBytes("00000000000000010000000000000001");
byte[] aad = System.Text.Encoding.UTF8.GetBytes("hello");
byte[] nonce = System.Text.Encoding.UTF8.GetBytes("000001111122");
int macSize = 128;

AeadParameters aeadParameters = new AeadParameters(new KeyParameter(key), macSize, nonce);

ChaCha20Poly1305 chaCha20Poly1305 = new ChaCha20Poly1305();

// true: Encrypt
// false: Decrypt
chaCha20Poly1305.Init(true, aeadParameters);

int osize = chaCha20Poly1305.GetOutputSize(plain.Length);

byte[] cipher = new byte[outputSize];

int outOff =  chaCha20Poly1305.ProcessBytes(plain, 0, plain.Length, cipher, 0);

chaCha20Poly1305.DoFinal(cipher, outOff);

