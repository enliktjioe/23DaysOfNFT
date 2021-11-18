

# NFT in 3 days

## References

- [Coding an NFT crypto collectible in 3 days](https://www.youtube.com/playlist?list=PLuZkwckxno0o7_GZoOBp2gnX5DfakVcxy)

## Notes

- Solidity is the programming language for blockchain



## Let's dig in

- Setup - Step by Step

  - Install Truffle `npm install -g truffle`
  - Init truffle project `truffle init` or `npx truffle init`
  - Install ganache
    - in macOS `brew install --cask ganache`

- Connect to Ganache
  ![1](img/readme/1.png)

- My private ETH blockchain on my local machine
  ![2](img/readme/2.png)

- Implement ERC721 and connect it to OpenSea

  - Install OpenZeppelin, a library for implementing different ERC tokens
    `npm install @openzeppelin/contracts`

  - Create sample file, Date.sol

  - Compile using `truffle compile`

    ![3](img/readme/3.png)

  - Run `truffle migrate`

    ![4](img/readme/4.png)

    

    ![5](img/readme/5.png)

    - We need Date file into deployment file

  - Create `2_token_migration.js` file inside `/migrations` folder for 2nd deployment process
    

    ![6](img/readme/6.png)


    ![7](img/readme/7.png)

  - 

- 

