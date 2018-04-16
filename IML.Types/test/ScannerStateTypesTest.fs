// Copyright (c) 2018 Intel Corporation. All rights reserved.
// Use of this source code is governed by a MIT-style
// license that can be found in the LICENSE file.

module IML.DeviceScannerDaemon.ScannerStateTypesTest


open Fable.Import.Jest
open Matchers
open Thot.Json

open IML.Types.ScannerStateTypes
open IML.CommonLibrary

open Fixtures

test "decode / encode scannerState" <| fun () ->
    fixtures.scannerState
      |> Decode.decodeString State.decoder
      |> Result.unwrap
      |> State.encode
      |> Encode.encode 2
      |> toMatchSnapshot