// Sha384Digest sha384 = new Sha384Digest();
// ...

Sha256Digest sha256 = new Sha256Digest();

byte[] bytes = System.Text.Encoding.UTF8.GetBytes("hello");

sha256.BlockUpdate(bytes,0,bytes.Length);

byte[] buf = new byte[sha256.GetDigestSize()];

sha256.DoFinal(buf);

Console.WriteLine(Convert.ToHexString(buf));


