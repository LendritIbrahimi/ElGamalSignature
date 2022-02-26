# ElGamal Encryption &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/LendritIbrahimi/ElGamalSignature/blob/master/LICENSE)

The aim of this project is to extend the Microsoft **[.NET framework](https://dotnet.microsoft.com/en-us/)** by implementing the ElGamal encryption algorithm.

By necessity the **C#** language was used for the implementation details of the algorithm and the Windows Forms (**WinForms**) library for the GUI side of the application.

The implementation of this algorithm has been adapted from the **[eTutorials](http://etutorials.org/)** chapter [15.3 Extending the .NET Framework](http://etutorials.org/Programming/Programming+.net+security/Part+III+.NET+Cryptography/Chapter+15.+Asymmetric+Encryption/15.3+Extending+the+.NET+Framework/?fbclid=IwAR3YQ16U1oiUFXItcU4pHlS8wgZuC31KvbrDwnbcHh12LBpwFgLlikMl2ww%2F/).

## Cryptography

In cryptography, the **[ElGamal encryption](https://en.wikipedia.org/wiki/ElGamal_encryption)** system is an asymmetric key encryption algorithm for public-key cryptography.

A **[digital signature](https://en.wikipedia.org/wiki/Digital_signature)** is a mathematical technique used to validate the authenticity and integrity of a message, software or digital document.

ElGamal encryption is used in the free **[GNU Privacy Guard](https://gnupg.org/)** software, recent versions of **[Pretty Good Privacy](https://en.wikipedia.org/wiki/Pretty_Good_Privacy)** (PGP), and other cryptosystems.

## Installation and Execution
To run this you can choose one of two paths:

1. Releases
   - Go to https://github.com/lendritbrahimi/elgamalsignature/releases
   - download the latest relase assets
   - execute the **.exe** file, or

2. Visual Studio
   - Download Visual Studio from https://visualstudio.microsoft.com/downloads/
   - Download the source code 
   
   ![Download the source code](https://drive.google.com/uc?export=view&id=1svkjbWMWeZK4RJ9Q5mRAlzBr4gd3W-fT)
   - Open the **.sln** in Visual Studio
   - Build and Run project

   ![Run](https://drive.google.com/uc?export=view&id=1YTl73yACNpHhf5JE7VuXC7dty2DMZIMx)

## Usage

You can use this project to make a digital signature for a message by using the ElGamal Encryption method.

It supports two primary modes of execution:

### 1. Automatic

   ![Automatic mode](https://drive.google.com/uc?export=view&id=1zEuG4hJGlMXCp7bmAj7KjPj97ttsJuyA)
   
   This mode has only input field which is the message awaiting to be signed, the keys will be generated randomly and a digital signature will be shown.

  ![Automatic mode test](https://drive.google.com/uc?export=view&id=19U6ysCSgAXVKYS-Zj4Kf4P2FXdwf_zd7)
  
### 2. Manual

   ![Manual mode](https://drive.google.com/uc?export=view&id=1cv_JuyjDWPHoCu96kTmQMgB2mtoKpn_e)

This mode has multiple input fields: one for the message, three for the public keys and one for the private key. A digital signature will be shown.

   ![Manual mode test](https://drive.google.com/uc?export=view&id=1yQ9Yd44feuW9NgPK7nA-Vunoh2NBQgPn)
   
## Contributing

This project is closed, and will not be updated further.

The collaborators and creators of this project in alphabetical order are: 

@kastriotsalihu1 - Kastriot Salihu

@LendritIbrahimi - Lendrit Ibrahimi

## License 

This project is [MIT licensed](./LICENSE).

