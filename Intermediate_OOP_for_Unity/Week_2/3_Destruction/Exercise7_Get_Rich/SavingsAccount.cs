﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7 {
    class SavingsAccount : InvestmentAccount {
        protected float interestRate;

        public SavingsAccount(float interestRate) : base() {
            this.interestRate = interestRate;          
        }

        public override string ToString() {
            return base.ToString();
        }

        public override void UpdateBalance() {
            throw new NotImplementedException();
        }
    }
}