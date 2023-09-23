# EncryptionApplication
The DES Algorithm is a block cipher that uses symmetric keys to convert 64-bit plaintext blocks into 48-bit ciphertext blocks. The (DES) Data Encryption Standard Algorithm was developed by the IBM team in the 1970s. It has since been accepted by the National Institute of Standards and Technology (NSIT).

**Advantages of DES Algorithm**

The advantages are as follows:

• The algorithm has been in use since 1977. Technically, no weaknesses have been found in the algorithm. Brute force attacks are still the most efficient attacks against the DES algorithm.

• DES is the standard set by the US Government. The government recertifies DES every five years, and has to ask for its replacement if the need arises.

• The American National Standards Institute (ANSI) and International Organization for Standardization (ISO) have declared DES as a standard as well. This means that the algorithm is open to the public—to learn and implement.

• DES was designed for hardware; it is fast in hardware, but only relatively fast in software.

**Disadvantages of DES Algorithm**

The disadvantages are as follows:

• Probably the biggest disadvantage of the DES algorithm is the key size of 56-bit. There are chips available that can encrypt and decrypt a million DES operations in a second.

• DES can be implemented quickly on hardware. But since it was not designed for software, it is relatively slow on it.

• It has become easier to break the encrypted code in DES as the technology is steadily improving. Nowadays, AES is preferred over DES.

• DES uses a single key for encryption as well as decryption as it is a type of symmetric encryption technique. In case that one key is lost, we will not be able to receive decipherable data at all.


You may need encrypt your file to protect that and decrypt it for using. this application can help you and it is developed by c#.

To encrypt/decrypt file i used DESCryptoService and it defines a wrapper object to access the cryptographic service provider (CSP) version of the Data Encryption Standard (DES) algorithm. This class cannot be inherited.
![image](https://github.com/Sooheil/EncryptionApplication/assets/40947759/290c354b-abb3-4244-b074-a47c151ff8af)
For using you nead to make your special key and initialization vector (IV) used to encrypt the file must be used to decrypt it. After that you should select your source file and destination path for encrypting/decrypting.

You can read more https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.descryptoserviceprovider?view=net-7.0
