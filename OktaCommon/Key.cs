﻿namespace OktaCommon {

    public enum KeyType {
        Unknown,
        DeviceAttestation,
        UserVerification,
        ProofOfPossession,
        Backdoor
    }

    public class Key {
        public string KeyId;
        public bool Sandboxed;
        public string Path;
        public KeyType Type;
    }
}
