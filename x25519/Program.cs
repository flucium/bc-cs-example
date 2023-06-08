X25519PrivateKeyParameters bob = new X25519PrivateKeyParameters(new SecureRandom());

X25519PrivateKeyParameters alice = new X25519PrivateKeyParameters(new SecureRandom());


// B
X25519Agreement x25519AgreementBob = new X25519Agreement();

byte[] bobBuf = new byte[x25519AgreementBob.AgreementSize];
x25519AgreementBob.Init(bob);
x25519AgreementBob.CalculateAgreement(alice.GeneratePublicKey(), bobBuf);
//Console.WriteLine(Convert.ToBase64String(bobBuf));





// A
X25519Agreement x25519AgreementAlice = new X25519Agreement();
byte[] aliceBuf = new byte[x25519AgreementAlice.AgreementSize];
x25519AgreementBob.Init(alice);
x25519AgreementBob.CalculateAgreement(bob.GeneratePublicKey(), aliceBuf);
// Console.WriteLine(Convert.ToBase64String(aliceBuf));




