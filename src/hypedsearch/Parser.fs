namespace HypedSearch.Parser

open HypedSearch.Domain

module MzML =
    let parse(path : string) : MassSpectrum = failwith "Not implemented"

module Fasta = 
    let parse(path : string) : seq<Protein> = failwith "Not implemented"
