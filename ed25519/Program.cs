byte[] msg = System.Text.Encoding.UTF8.GetBytes("hello");

// Private Key
Ed25519PrivateKeyParameters ed25519 = new Ed25519PrivateKeyParameters(new SecureRandom());

var publickey = ed25519.GeneratePublicKey();

// Sign
ISigner signer =new Ed25519Signer();
signer.Init(true, ed25519);
signer.BlockUpdate(msg);
byte[] signature=signer.GenerateSignature();
Console.WriteLine(Convert.ToHexString(signature));


// Verify
signer = new Ed25519Signer();
signer.Init(false,new Ed25519PublicKeyParameters(publickey.GetEncoded()));
signer.BlockUpdate(msg);
Console.WriteLine(signer.VerifySignature(signature));

