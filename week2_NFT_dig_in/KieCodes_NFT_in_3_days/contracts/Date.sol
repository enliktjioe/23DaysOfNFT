pragma solidity >=0.4.22 <0.9.0;

import "@openzeppelin/contracts/token/ERC721/ERC721.sol";

contract Date is ERC721 {
    constructor() ERC721("Date", "DATE") {}
}