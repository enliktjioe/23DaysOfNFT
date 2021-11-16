﻿using NBitcoin;
using NBitcoin.DataEncoders;

namespace Stratis.Sidechains.Networks
{
    public static class CirrusNetwork
    {
        /// <summary> The name of the root folder containing the different side chain block data.</summary>
        public const string NetworkRootFolderName = "cirrus";

        /// <summary> The default name used for the side chain configuration file. </summary>
        public const string NetworkDefaultConfigFilename = "cirrus.conf";
        
        public static Block CreateGenesis(ConsensusFactory consensusFactory, uint genesisTime, uint nonce, uint bits, int version, Money reward, string coinbaseText)
        {
            Transaction genesisTransaction = consensusFactory.CreateTransaction();
            // TODO: Remove Cirrus networks from this solution?
            //genesisTransaction.Time = genesisTime;
            genesisTransaction.Version = 1;
            genesisTransaction.AddInput(new TxIn()
            {
                ScriptSig = new Script(Op.GetPushOp(0), new Op()
                {
                    Code = (OpcodeType)0x1,
                    PushData = new[] { (byte)42 }
                }, Op.GetPushOp(Encoders.ASCII.DecodeData(coinbaseText)))
            });

            genesisTransaction.AddOutput(new TxOut()
            {
                Value = reward
            });

            Block genesis = consensusFactory.CreateBlock();
            genesis.Header.BlockTime = Utils.UnixTimeToDateTime(genesisTime);
            genesis.Header.Bits = bits;
            genesis.Header.Nonce = nonce;
            genesis.Header.Version = version;
            genesis.Transactions.Add(genesisTransaction);
            genesis.Header.HashPrevBlock = uint256.Zero;
            genesis.UpdateMerkleRoot();
            
            return genesis;
        }
    }
}