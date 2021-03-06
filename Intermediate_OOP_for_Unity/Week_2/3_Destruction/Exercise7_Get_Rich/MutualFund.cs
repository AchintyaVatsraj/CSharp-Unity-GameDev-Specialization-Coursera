﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7 {
    class MutualFund : InvestmentAccount {

        protected const float ServiceChargePercent = 0.01f;
        const float GrowthPercent = 0.01f;

        public MutualFund(float deposit = 0) : base(deposit) {
        }

        public override void AddMoney(float amount) {
            base.AddMoney(amount * (1 - ServiceChargePercent));
        }

        public override string ToString() {
            return "Mutual Fund. Balance: " + balance;
        }

        public override void UpdateBalance() {
            balance *= 1 + GrowthPercent;
        }
    }
}
