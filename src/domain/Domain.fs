﻿namespace Domain

[<AutoOpen>]
module Domain =
    type AminoAcid = A | R | N | D | C | Q | E | G | H | I | L | K | M | F | P | O | S | U | T | W | Y | V | B | Z | X 

    type Precursor = {
        mass: double
        charge: int
    }

    type Spectrum = {
        id: string
        mz: seq<double>
        intensity: seq<double>
        precursor: Precursor
    }

